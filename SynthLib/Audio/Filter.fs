namespace SynthLib.Audio

open System
open SynthLib.Variables

module Filter =
    let Amplitude (amplitudeChange : float) (wave : List<float>) =
        wave |> List.map (fun x -> x * amplitudeChange)

    let Overdriven (amplitude : float) (wave : List<float>) =
        let absAmplitude = Math.Abs(amplitude)
        [ for y in wave do
            if y < -absAmplitude then yield -absAmplitude
            elif y > absAmplitude then yield absAmplitude
            else yield y
        ]

    let Echo (distance : float) (wave : List<float>) = // Add echo to the sound
        let time = (2.0 * distance * 1000.0) / 340.0 // value in ms
        let indexEchowave = Convert.ToInt32(time * float sampleRate / 1000.0 )// find the first index for the echowave
        let echowave = // just the echo wave
            [ for t in 0 .. 1 .. wave.Length - 1 + indexEchowave do
              if t < indexEchowave then yield 0. else yield wave.[t - indexEchowave]

            ]
        let echowavesum = // sum of the two waves
            [ for t in 0 .. 1 .. wave.Length - 1 + indexEchowave do
                if t < indexEchowave then yield wave.[t] elif t > wave.Length - 1 then yield echowave.[t] else yield echowave.[t] + wave.[t]

            ]
        echowavesum

    let Flange (wave : List<float>) = // Add flange to the sound 
        [
        //setting the parameters of the effect
        let maxTimeDelay = 0.003
        let speed = 1.

        //setting the maximum delay depending on samplerate
        let maxSampleDelay = int (maxTimeDelay * float sampleRate)
        let mutable currentDelay = 0

        //setting the coefficient qnd currentSin variables that will be usefull later
        //currentSine being the Sine function at a point in time
        let coefficient = 0.5
        let mutable currentSine = 0.

        //for each sample 
        for i in 0..wave.Length-1 do

            //avoid modifying samples before maxDelay+1 to avoid negativ index
            if i < maxSampleDelay+1 then yield wave.[i]
            else
                //Giving a value to currentSine
                currentSine <- abs(sin(2. * Math.PI * (float i) * (speed / (float sampleRate))))

                //Calculating the currentDelay from currentSine
                currentDelay <- int(currentSine * (float maxSampleDelay))

                //Calculating output
                yield (coefficient * wave.[i]) + (coefficient * wave.[i-currentDelay])
        ]

    let Reverb = // A reverb effect filter, wikipedia has a description of reverberation: https://en.wikipedia.org/wiki/Reverberation
        0
