namespace Synth

open System
open Variables

module Filter =
    let Amplitude (amplitudeChange : float) (wave : List<float>) = // Modify the wave’s amplitude by a fixed amount
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

    let Echo = // Add echo to the sound
        0

    let Flange = // A flange effect filter, for a description of this effect see wikipedia: https://en.wikipedia.org/wiki/Flanging
        0

    let Reverb = // A reverb effect filter, wikipedia has a description of reverberation: https://en.wikipedia.org/wiki/Reverberation
        0