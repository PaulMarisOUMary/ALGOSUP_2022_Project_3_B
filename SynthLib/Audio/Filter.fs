namespace SynthLib.Audio


module Filter =

    open System
    open SynthLib.Variables
    
    
    let Amplitude (amplitudeChange : float) (wave : List<float>) =
        wave |> List.map (fun x -> x * amplitudeChange)

    let Overdriven (amplitude : float) (wave : List<float>) =
        let absamp = abs(amplitude)
        wave |> List.map (fun x -> if abs(x) < absamp then x else ( float (sign(x)) * absamp))

    let Echo (duration : float) (wave : List<float>) = // Add echo to the sound
        let subAmplitude = 1. / ( duration + 1.)// 10m -> 1% | distance / 10m -> s%
        let weakWave = wave |> Amplitude (subAmplitude) // wave to "merge/paste" next to the original wave
        let echo = (Wave.MakeNote (Wave.Identity) duration Note.REST 4) @ weakWave
        Wave.Combine([wave; echo])
        
    let Flange (maxTimeDelay : float) (speed : float) (wave : List<float>) = // Add flange to the sound 
        [
        //setting the parameters of the effect
        //maxTimeDalay in between 0.003 and 0.015 seconds
        //speed in between 1 and 15 Hz


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
        for i in [1 .. times] do
            final <- Wave.Combine [Echo (firstDuration * float i) (wave); final]
        final

    let LowPass cutoffFreq (data:List<float>) =
        [
        let pi = Math.PI

        let RC = 1. / (2. * pi * cutoffFreq)
        let dt = 1. / (float sampleRate)
        let alpha = RC / (RC + dt)
        let mutable temp = 0.

        let mutable last = (alpha*data.[0])
        for i in 1..(data.Length-1) do
            temp <- ((alpha * data.[i]) + ((1. - alpha) * last))
            yield temp
            last <- temp 
        ]

    let HighPass cutoffFreq (data : List<float>) =
        [
        let pi = Math.PI

        let RC = 1. / (2. * pi * cutoffFreq)
        let dt = 1. / (float sampleRate)
        let alpha = RC / (RC + dt)
        let mutable temp = 0.

        let mutable last = data.[0]

        for i in 1..(data.Length - 1) do
            temp <- (alpha * last) + alpha * (data.[i] - data.[i-1])
            yield temp
            last <- temp
        ]


    let LfoAmp (rate : float)(depth : float)(typewave)(wave : List<float>)= //apply a LFO to the amplitude of sound
        [
            let mutable currentlfo = 0.
            for i in 0..(wave.Length-1) do
                currentlfo <- (typewave (rate/(float sampleRate)) (float i))/2. + 0.75
                yield wave.[i] * (1.-(currentlfo*depth))
        ]


    type waveTypeFilter =
    | Sine
    | Square
    | Triangle
    | Sawtooth

    let LfoFreq (rate: float)(depth: float) note octave (typewave : waveTypeFilter)(wave : List<float>) = // apply LFO to an low pass filter in order to variate the frequencie
        // rate : frequency between 0 to 10 Hz
        // depth : amplitude of the effect (float -> 0 à 10)
        [
            let frq = Note.GetFrequency note octave
            let pi = Math.PI

            let (mod) x y=
              (x%y + y)%y

            match typewave with
            | waveTypeFilter.Sine -> 
                for i in 0..wave.Length-1 do
                    yield Math.Sin(2.*pi*frq*(float i/float sampleRate)+(depth*frq*Math.Sin(2.*pi*rate*(float i/float sampleRate))))
            | waveTypeFilter.Square ->
                for i in 0..wave.Length-1 do
                    yield if Math.Sin(2.*pi*frq*(float i/float sampleRate)+(depth*frq*Math.Sin(2.*pi*rate*(float i/float sampleRate)))) > 0. then 1. else - 1.
            | waveTypeFilter.Triangle ->
                for i in 0..wave.Length-1 do
                    yield   Math.Asin(Math.Sin(2.*pi*frq*(float i/float sampleRate)+(depth*frq*Math.Sin(2.*pi*rate*(float i/float sampleRate))))) * (2.0/pi)  
            | waveTypeFilter.Sawtooth -> 
                for i in 0..wave.Length-1 do
                    yield ((2. * (float i / float sampleRate) * (2.*pi*frq*(float i/float sampleRate)+(depth*frq*Math.Sin(2.*pi*rate*(float i/float sampleRate))))) mod 2.) - 1.
            
        ]

    let LfoHighPass (rate:float)(depth:float)(typewave)(wave:List<float>) =
        [
            let pi = Math.PI

            let mutable currentlfo = 9000.
            let mutable RC = 1. / (2. * pi * currentlfo)
            let dt = 1. / (float sampleRate)
            let mutable alpha = RC / (RC + dt)
            let mutable temp = 0.

            let mutable last = (alpha*wave.[0])
            
            for i in 1..(wave.Length-1) do
                currentlfo <- ((typewave (rate/(float sampleRate)) (float i))*6000.)+7500.
                RC <- 1. / (2. * pi * currentlfo)
                alpha <- RC / (RC + dt)
                temp <- (alpha * wave.[i]) + ((1. - alpha) * last)
                yield temp 
                last <- temp
        ]

            
           