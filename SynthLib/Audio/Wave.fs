namespace SynthLib.Audio

module Wave =

    open System
    open SynthLib.Variables
    open System.Collections.Generic
    
    let PI = Math.PI

    let (mod) x y=
        (x%y + y)%y

    let Sine frequency t = sin(2. * PI * frequency * t)

    let Square frequency t = if (Math.Sin(2. * PI * frequency * t)) > 0. then 1. else - 1.

    let Triangle frequency t = let p = 1./frequency in (4. / p) * Math.Abs(((t - p/4.) mod p) - p/2.) - 1.

    let Sawtooth frequency t = ((2. * t * frequency) mod 2.) - 1.

    let Identity _ _ = 0.

   // let Triangle frequency t = (8./(PI*PI))*(cos(2.0*PI*t*frequency)+ (1./9.)* cos(2.0*PI*t*frequency*3.)+ (1./25.)* cos(2.0*PI*t*frequency*5.))


    let MakeNote generator (duration:float) note octave =
        let calculatedFrequency = Note.GetFrequency note octave in
        [
            for t in 0. .. 1. .. duration * (float sampleRate) do
                yield  t / float sampleRate |> generator calculatedFrequency
        ]

    let Combine (args: list<list<float>>) =

        let maxlength = args |> List.map List.length |> List.max
        let refactorarraywith0 = [
            for x in args do
                [
                    for y in 0.. 1 ..maxlength-1 do
                        if y > x.Length-1 then yield 0. else yield x.[y]
                ]
        ]

        [
             for y in 0.. 1 ..maxlength-1 do
                let listtosum = [for x in refactorarraywith0 do yield x.[y]]
                listtosum |>List.map(fun x -> x/ ( listtosum|>List.where(fun x -> x <> 0.)|>List.length|>float))|> List.sum

        ]
       (* [
             for x in result do if x <> 0. then yield x / float args.Length
        ]
        *)
