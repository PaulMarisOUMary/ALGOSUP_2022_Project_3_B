namespace Synth

open Synth

module Program =
    [<EntryPoint>]
    let main _  =
        printf "Hello world"
        let test = Sample()
        printfn $"test: {test.SampleMethod}"
        0