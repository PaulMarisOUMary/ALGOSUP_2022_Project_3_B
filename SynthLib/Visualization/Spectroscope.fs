namespace SynthLib.Spectroscope

open System
open System.Collections.Generic
open System.Numerics
open FSharp.Core
open FftSharp

// new Complex(input,0.)
module Spectroscope =
    (*let private CreateHanning (len : int) = 
        [
            for i in 0 .. 1 .. len-1 do
                yield (0.5 - ( 0.5 * cos(2. * Math.PI * (float i) / float len)))
        ]

    let ApplyHanning wave =
        wave |> List.length |> CreateHanning |> List.map2(fun w x -> w * x)
    *)
    let IsPow2 (x: int) = ((x &&& (x - 1)) = 0) && (x > 0)

    let PadToPow2 (input: float[]) =
        if (IsPow2 input.Length) then input else
            let mutable target = 1
            while target < input.Length do
                target <- target * 2
            let toadd = target - input.Length
            let padded = Array.create target 0.
            Array.Copy(input,0 ,padded, toadd/2, input.Length)
            padded
    (*
    let rec private  lFFT (complexWave : List<Complex>) =
        let out = new List<Complex>()
        let halflen = (complexWave.Count) / 2
        let even = new List<Complex>()
        let odd = new List<Complex>()
        for i = 0 to halflen-1 do
            even.Add complexWave[i*2]
            odd.Add complexWave[i*2 + 1]
        let (odds : List<Complex>) =  if halflen > 1 then lFFT odd else odd
        let (evens : List<Complex>) = if halflen > 1 then lFFT even else even
        let m = - 2. * (Math.PI / (float complexWave.Count))

        for i = 0 to halflen-1 do
            let rad = m * float i
            odds.[i] <- odds.[i] * (new Complex(cos(rad),sin(rad)))

        for i = 0 to halflen-1 do
            out.Insert(i , (evens.[i] + odds.[i]))
            out.Add  (evens.[i] - odds.[i])
        out

    let FFT wave = new List<Complex> (wave |> List.map(fun x -> new Complex(x,0.)))|> PadToPow2 |> lFFT |> Seq.toList
*)
    let fft wave = wave |> List.toArray |> PadToPow2 |> FftSharp.Transform.FFTmagnitude
