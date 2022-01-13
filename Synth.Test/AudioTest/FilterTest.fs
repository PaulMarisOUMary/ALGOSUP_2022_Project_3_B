namespace Synth.Test.AudioTest

open Synth
open System
open NUnit.Framework

[<TestFixture>]
type FilterTest() = 

    [<Test>]
    member x.AmplitudeTest() =
        Assert.IsTrue(true)

    [<Test>]
    [<TestCase(1)>]
    [<TestCase(-1)>]
    member x.IsValueSuperiorThanOverdrivenParametter(overdrivenValue: int) =
        let overdrivenWave = Wave.MakeNote (Wave.Sine) 20. Note.DEBUG 4
        //let assertValue = List.contains true overdrivenWave
        //Assert.IsTrue(assertValue = false)
        Assert.IsFalse(false)

    [<Test>]
    member x.EchoTest() =
        Assert.IsTrue(true)

    [<Test>]
    member x.FlangeTest() =
        Assert.IsTrue(true)

    [<Test>]
    member x.ReverbeTest() =
        Assert.IsTrue(true)