namespace Synth

open Synth
open Wave
open System.IO

module Program =
    [<EntryPoint>]
    let main _  =
        
        let sample x = (x + 1.)/2. * 255. |> byte 
        
        let data = Array.init 16000 (fun i -> sin (float i/float 8) |> sample)

        EncodetoWav "../../../Hello.wav" data []
        
        0