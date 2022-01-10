namespace Synth

open Synth
open System

module Program =
    [<EntryPoint>]
    let main _  =
        printf "Hello world"

        let (mod) x y=
            (x%y + y)%y
              
        let a = 2.
        let b = 1.
        let x = 0.
        let p = Math.PI * b
        
        let Sinus = [
            for x in 0. .. 0.01 .. 20. do yield (x , (a * Math.Sin(x/b)))
            ]
        let Square = [
            for x in 0. .. 0.01 .. 20. do yield (x , if (a * Math.Sin(x/b)) > 0. then a else -a)
            ]
        let Triangle= [
            for x in 0. .. 0.01 .. 20. do let f = x/b in yield (x , (4.*a/p)*Math.Abs(((x- p/4.)mod p) - p/2.) - a)//(a*(Math.Abs(f%4.-2.)-1.)))
            ]
        let Tooth = [
            for x in 0. .. 0.01 .. 20. do yield (x , (a*(((2. * x/p)) mod 2.)-a))
            ]
        
        let Waves : List<List<float * float>> = [ Sinus; Square; Triangle; Tooth ]

        Synth.Visualization.Chart(Waves)



        0
