namespace Synth

type Filter =
    member x.Amplitude = // Modify the wave’s amplitude by a fixed amount
        0

    member x.Overdriven amplitude =
        // Cut off the wave at specific amplitude to given the “overdriven” often used in rock songs
        0

    member x.Echo = // Add echo to the sound
        0

    member x.Flange = // A flange effect filter, for a description of this effect see wikipedia: https://en.wikipedia.org/wiki/Flanging
        0

    member x.Reverb = // A reverb effect filter, wikipedia has a description of reverberation: https://en.wikipedia.org/wiki/Reverberation
        0