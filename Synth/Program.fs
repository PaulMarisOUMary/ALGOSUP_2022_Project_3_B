namespace Synth

open Synth
open System

module Program =
    [<EntryPoint>]
    let main _  =
        printf "Hello world"

        let a = 1.
        let h = 0.
        let b = 0.5
        let k = 0.
        let x = 0.
        
        let Sinus = [
            for x in 0. .. 0.01 .. 20. do yield (x , (a * Math.Sin((x  - h) / b) + k))
            ]
        let Square = [
            for x in 0. .. 0.01 .. 20. do yield (x , if (a * Math.Sin((x  - h) / b) + k) > 0. then 1. else -1.)
            ]
        let Triangle= [
            for x in 0. .. 0.01 .. 20. do yield (x , (Math.Abs(x%4.-2.)-1.))
            ]
        let Tooth = [
            for x in 0. .. 0.01 .. 20. do yield (x , ((x%2.)-1.))
            ]
        
        let Waves : List<List<float * float>> = [ Sinus ; Square; Triangle; Tooth]

        Synth.Visualization.Chart(Waves)



        0
