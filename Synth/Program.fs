namespace Synth

open Synth

module Program =
    [<EntryPoint>]
    let main _  =

        let amplitude = 1.
        let frequency = 1.
        let from = 0.
        let step = 0.01
        let until = 20.

        let Waves : List<List<float>> = [
//            Wave.MakeNote (Wave.Sine) 20 Note.A 0
//            Wave.MakeNote (Wave.Triangle) 20 Note.A 0
//            Wave.MakeNote (Wave.Sawtooth) 20 Note.A 0
            Wave.MakeNote (Wave.Square) 20 Note.A 4
        ]

        
        Synth.Visualization.Chart Waves 1200 250

        0