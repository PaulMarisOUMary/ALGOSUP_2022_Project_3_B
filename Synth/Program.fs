namespace Synth

open Synth.Visualization
open System

module Program =
    [<EntryPoint>]
    let main _  =
        printf "Hello world"

        let (mod) x y=
            (x%y + y)%y
              
        let amplitude = 1.
        let frequency = 1.
        let x = 0.
        let piFrequency = Math.PI* 2. * frequency
        
        let Sinus = [
            for x in 0. .. 0.01 .. 20. do yield (x , (amplitude * Math.Sin(x/frequency)))
            ]
        let Square = [
            for x in 0. .. 0.01 .. 20. do yield (x , if (amplitude * Math.Sin(x/frequency)) > 0. then amplitude else -amplitude)
            ]
        let Triangle= [
            for x in 0. .. 0.01 .. 20. do let f = x/frequency in yield (x , (4.*amplitude/piFrequency)*Math.Abs(((x- piFrequency/4.)mod piFrequency) - piFrequency/2.) - amplitude)//(a*(Math.Abs(f%4.-2.)-1.)))
            ]
        let Tooth = [
            for x in 0. .. 0.01 .. 20. do yield (x , (amplitude *(((2. * x/piFrequency)) mod 2.)-amplitude))
            ]
        
        let Waves : List<List<float * float>> = [ Sinus; Square; Triangle; Tooth ]

        Synth.Visualization.Chart Waves 1200 250



        0
