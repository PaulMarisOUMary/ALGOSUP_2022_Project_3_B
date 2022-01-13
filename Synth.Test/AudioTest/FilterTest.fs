namespace Synth.Test.AudioTest

open Synth
open Synth.Variables
open System
open NUnit.Framework

[<TestFixture>]
type FilterTest() = 

    [<Test>]
    member x.AmplitudeTest() =
        Assert.IsTrue(true)

    [<Test>]
    [<TestCase(1)>]
    [<TestCase(0.75)>]
    [<TestCase(1.)>]
    [<TestCase(-1.)>]
    member x.IsValueSuperiorThanOverdrivenParametter(overdrivenValue) =
        // Arrange
        let overdrivenWave = Wave.MakeNote (Wave.Sine) 20. Note.DEBUG 4 |> Filter.Amplitude 4. |> Filter.Overdriven overdrivenValue
        let absOverdrivenValue = Math.Abs(overdrivenValue)

        // Act
        let overdrivenWaveCheck : List<bool> = [
            for value in overdrivenWave do
                if value > absOverdrivenValue then yield true
                elif value < -absOverdrivenValue then yield true
                else yield false
        ]
        let assertValue = List.contains true overdrivenWaveCheck

        // Assert
        Assert.AreEqual(assertValue, false)

    [<Test>]
    member x.EchoTest() =
        Assert.IsTrue(true)

    [<Test>]
    member x.FlangeTest() =
        Assert.IsTrue(true)

    [<Test>]
    member x.ReverbeTest() =
        Assert.IsTrue(true)