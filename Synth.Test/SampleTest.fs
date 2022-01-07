namespace Synth.Test

open Synth
open System
open NUnit.Framework

[<TestFixture>]
type SampleTest() =

    [<Test>]
    member x.ShouldReturnSample () =
        let test = Sample()
        Assert.IsTrue(test.SampleMethod = "Sample!")
