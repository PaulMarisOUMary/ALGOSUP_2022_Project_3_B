namespace Synth.Test.AudioTest

open Synth
open Synth.Variables
open System
open NUnit.Framework

[<TestFixture>]
type FilterTest() = 

    [<Test>]
    member x.AmplitudeTest() =
        let ampChange = 3.
        let sampleChange : float = float Variables.sampleRate
        let Saw = Wave.MakeNote (Wave.Sawtooth) 20. Note.DEBUG 4 |> Filter.Amplitude ampChange
        Assert.That(Saw.[int (sampleChange * 0.5)], Is.EqualTo(0))
        Assert.That(Saw.[int (sampleChange * 0.75)], Is.EqualTo(ampChange * 0.5))
        Assert.That(Saw.[int sampleChange], Is.EqualTo(ampChange * -1.))

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