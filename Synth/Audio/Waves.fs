
namespace Synth

open System

type Waves(amplitude : float, frequency : float) =
    let amplitude = amplitude
    let frequency = frequency
    let piFrequency = Math.PI* 2. * frequency

    let (mod) x y=
        (x%y + y)%y

    member x.Sinus from step until =
        [
            for x in from .. step .. until do
                yield (x , (amplitude * Math.Sin(x/frequency)))
        ]

    member x.Square from step until =
        [
            for x in from .. step .. until do
                yield (x , if (amplitude * Math.Sin(x/frequency)) > 0. then amplitude else -amplitude)
        ]

    member x.Triangle from step until =
        [
            for x in from .. step .. until do
                let f = x/frequency in
                    yield (x , (4. * amplitude/piFrequency) * Math.Abs(((x- piFrequency/4.)mod piFrequency) - piFrequency/2.) - amplitude)
        ]

    member x.Tooth from step until =
        [
            for x in from .. step .. until do
                yield (x , (amplitude * (((2. * x/piFrequency)) mod 2.) - amplitude))
        ]

    member x.makeNote wave duration note octave =
        wave