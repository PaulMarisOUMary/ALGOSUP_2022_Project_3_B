namespace Synth

open Synth.Visualization
open Synth
open System

module Program =
    [<EntryPoint>]
    let main _  =
        printf "Hello world"

        let amplitude = 1.
        let frequency = 1.
        let from = 0.
        let step = 0.01
        let until = 20.
        let Wave = Waves(amplitude, frequency)
        
        let Waves : List<List<float * float>> = [
            Wave.Sinus from step until ;
            Wave.Square from step until ;
            Wave.Triangle from step until;
            Wave.Tooth from step until
        ]

        Synth.Visualization.Chart Waves 1200 250



        0
