namespace SynthLib.Chart

open SynthLib.Chart.Visualization
open SynthLib.Variables
open System
open System.Numerics
module Spectroscope =
    let SpecVisu song =
        let Waves : List<List<float>> = [
            [for x in song do
                if x <= 0. then
                    yield x * -1.
                else
                    yield x];
            [for y in song do
                if y >= 0. then
                    yield y * -1.
                else
                    yield y]
        ]
        SynthLib.Chart.Visualization.ChartBar Waves 1200 500

    // Function that allow to find the average amplitude
    let AmpSpect (wave: List<float>) =
        let mutable count = 0.
        let mutable all = 0.
        for i in wave do
            count <- count + 1.
            all <- all + i
        let res = all / count
        res

    let rec pow2 x n = match x with
        | _ when n*2 > x -> n
        | _              -> pow2 x (2*n)

    let rec fft = function
        | []  -> []
        | [x] -> [x] 
        | x ->
          x
          |> List.mapi (fun i c -> i % 2 = 0, c)
          |> List.partition fst
          |> fun (even, odd) -> fft (List.map snd even), fft (List.map snd odd)
          ||> List.mapi2 (fun i even odd -> 
              let btf = odd * Complex.FromPolarCoordinates(1., -2. * Math.PI * (float i / float x.Length ))
              even + btf, even - btf)
          |> List.unzip
          ||> List.append

    // Function that allow to find the frequency
    let FreqSpect (wave: List<float>) =
        let trimmedList = wave |> let len = wave |> List.length in let pow = pow2 len 1 in List.removeManyAt pow (len-pow)
        let l2 = wave.[0 .. trimmedList.Length]
        let output = 
            l2
            |> List.map (fun r -> Complex(r, 0.)) 
            |> fft
            |> List.map (fun c -> c.Real)
        let mutable res = (output.Length / (wave.Length / 10_000))
        res

// use

//    let input = [for x in 0. .. 15. -> cos(x)  + cos(4.0 * x)]
      
//    let output = 
//        input
//        |> List.map (fun r -> Complex(r, 0.)) 
//        |> fft
//        |> List.map (fun c -> c.Real)