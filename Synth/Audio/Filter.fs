﻿namespace Synth

module Filter =
    let Amplitude (amplitudeChange : float) (wave : List<float * float>) = // Modify the wave’s amplitude by a fixed amount
        [ for x, y in wave do
            yield (x, y * amplitudeChange)
        ]

    let Overdriven (amplitude : float) (wave : List<float * float>) =
        [ for x, y in wave do
            if y < -amplitude then yield (x, -amplitude)
            elif y > amplitude then yield (x, amplitude)
            else yield (x, y)
        ]

    let Echo = // Add echo to the sound
        0

    let Flange = // A flange effect filter, for a description of this effect see wikipedia: https://en.wikipedia.org/wiki/Flanging
        0

    let Reverb = // A reverb effect filter, wikipedia has a description of reverberation: https://en.wikipedia.org/wiki/Reverberation
        0