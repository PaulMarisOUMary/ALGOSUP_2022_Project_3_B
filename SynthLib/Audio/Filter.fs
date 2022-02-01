namespace SynthLib.Audio

open System
open SynthLib.Variables

module Filter =
    let Amplitude (amplitudeChange : float) (wave : List<float>) =
        wave |> List.map (fun x -> x * amplitudeChange)

    let Overdriven (amplitude : float) (wave : List<float>) =
        let absamp = abs(amplitude)
        wave |> List.map (fun x -> if abs(x) < absamp then x else ( float (sign(x)) * absamp))

    let Echo (duration : float) (wave : List<float>) = // Add echo to the sound
        let distance = 340. * duration // sound speed x duration = distance
        let subAmplitude = distance / 10. // 10m -> 1% | distance / 10m -> s%

        let weakWave = wave |> Amplitude (subAmplitude/100.) // wave to "merge/paste" next to the original wave

        let echo = (Wave.MakeNote (Wave.Sine) duration Note.REST 4) @ weakWave

        Wave.Combine([wave; echo])


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

    let Reverb (times: int) (firstDuration : float) (wave : List<float>) = // A reverb effect filter, wikipedia has a description of reverberation: https://en.wikipedia.org/wiki/Reverberation
        let mutable final = wave
        for i in [0 .. times] do
            if i = 0 then 
                final <- Wave.Combine [Echo (firstDuration) (wave) ; final]
            else
                final <- Wave.Combine [Echo (firstDuration * float i) (wave); final]


    let LowPass cutoffFreq (data:List<float>) =
        [
        let pi = Math.PI

        let RC = 1. / (2. * pi * cutoffFreq)
        let dt = 1. / (float sampleRate)
        let alpha = RC / (RC + dt)

        let mutable last = (alpha*data.[0])
        for i in 1..(data.Length-1) do
            yield (alpha * data.[i]) + ((1. - alpha) * last)
            last <- ((alpha * data.[i]) + ((1. - alpha) * last))
        ]

    let HighPass cutoffFreq (data : List<float>) =
        [
        let pi = Math.PI

        let RC = 1. / (2. * pi * cutoffFreq)
        let dt = 1. / (float sampleRate)
        let alpha = RC / (RC + dt)

        let mutable last = data.[0]

        for i in 1..(data.Length - 1) do
            yield (alpha * last) + alpha * (data.[i] - data.[i-1])
            last <- (alpha * last) + alpha * (data.[i] - data.[i-1])
        ]
    type Typewave =
        | SQUARE
        | SINE
        | TRIANGLE
        | SAWTOOTH

    let Lfo (rate: float)(depth: float)(typewave: Typewave)(wave : List<float>) = // apply LFO to the sound : see https://www.musicgateway.com/blog/how-to/what-is-lfo-low-frequency-oscillation
        // rate : frequency between 0 to 20 Hz
        // depth : amplitude of the wave (float -> 0 à 1) call the function amplitude with this
        let wavetype = 
            match typewave with
            | SQUARE -> Wave.Square
            | SINE -> Wave.Sine
            | TRIANGLE -> Wave.Triangle
            | SAWTOOTH -> Wave.Sawtooth
        let lfowave = Wave.MakeNote wavetype 2. Note.LFO 4 |> Amplitude depth
        let lfocombine = Wave.Combine([lfowave ; wave])
        lfocombine