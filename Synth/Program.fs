namespace Synth

open Synth

module Program =
    [<EntryPoint>]
    let main _  =

        let Waves : List<List<float>> = [
            Wave.MakeNote (Wave.Sine) 20 Note.DEBUG 4
            Wave.MakeNote (Wave.Triangle) 20 Note.DEBUG 4
            Wave.MakeNote (Wave.Sawtooth) 20 Note.DEBUG 4
            Wave.MakeNote (Wave.Square) 20 Note.DEBUG 4 |> Filter.Overdriven 0.5
        ]

        
        Synth.Visualization.Chart Waves 1200 250

        0