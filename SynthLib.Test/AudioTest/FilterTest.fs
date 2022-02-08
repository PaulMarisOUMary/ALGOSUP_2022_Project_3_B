namespace SynthLib.Test.AudioTest

open SynthLib
open SynthLib.Variables
open SynthLib.Audio
open System
open NUnit.Framework

[<TestFixture>]
type FilterTest() = 

    [<Test>]
    [<TestCase(1.)>]
    [<TestCase(2.)>]
    [<TestCase(3.)>]
    [<TestCase(1.5)>]
    [<TestCase(-1.)>]
    member x.AmplitudeTest(ampChange: float) =
        let sampleChange : float = float Variables.sampleRate
        let Saw = Wave.MakeNote (Wave.Sawtooth) 2. Note.DEBUG 4 |> Filter.Amplitude ampChange
        Assert.That(Saw.[int (sampleChange * 0.5)], Is.EqualTo(0))
        Assert.That(Saw.[int (sampleChange * 0.75)], Is.EqualTo(ampChange * 0.5))
        Assert.That(Saw.[int sampleChange], Is.EqualTo(ampChange * -1.))

    [<Test>]
    [<TestCase(1)>]
    [<TestCase(0.75)>]
    [<TestCase(1.)>]
    [<TestCase(-1.)>]
    member x.IsValueSuperiorThanOverdrivenParameter(overdrivenValue) =
        // Arrange
        let overdrivenWave = Wave.MakeNote (Wave.Sine) 2. Note.DEBUG 4 |> Filter.Amplitude 4. |> Filter.Overdriven overdrivenValue
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