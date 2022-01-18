namespace Synth

open System
open Variables

module Filter =
    let Amplitude (amplitudeChange : float) (wave : List<float>) =
        [ for y in wave do
            yield y * amplitudeChange
        ]

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

    let Flange (wave : List<float>) = // A flange effect filter, for a description of this effect see wikipedia: https://en.wikipedia.org/wiki/Flanging
        [
        let maxTimeDelay = 0.003
        let speed = 1.
        let mutable currentDelay = 0
        let maxSampleDelay = int (maxTimeDelay * float sampleRate) //could be error
        let coefficient = 0.5
        let mutable currentSin = 0.
        for i in maxSampleDelay+1..wave.Length-1 do
            if i < maxSampleDelay+1 then yield wave[i]
            else
                currentSin <- abs(sin(2. * Math.PI * (float i) * (speed / (float sampleRate))))
                currentDelay <- int(currentSin * (float maxSampleDelay))
                yield (coefficient * wave[i]) + (coefficient * wave[i-currentDelay])
        ]

    let Reverb = // A reverb effect filter, wikipedia has a description of reverberation: https://en.wikipedia.org/wiki/Reverberation
        0