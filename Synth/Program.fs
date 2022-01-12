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
        let Wave = Waves(amplitude, frequency)
        
        let Wavee : List<List<float * float>> = [
            Wave.Sinus from step until ;
            Wave.Square from step until ;
            Wave.Triangle from step until;
            Wave.Tooth from step until
        ]

        let TestW = Waves(1.75, frequency)
        let value = TestW.Tooth from step until |> Filter.Overdriven 0.75


        Synth.Visualization.Chart [value] 1200 250

        0