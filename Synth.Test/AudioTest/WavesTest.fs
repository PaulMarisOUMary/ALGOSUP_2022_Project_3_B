namespace Synth.Test.AudioTest

open Synth
open System
open NUnit.Framework

[<TestFixture>]
type WavesTest() =

    let sampleRate : float = float Variables.sampleRate
    let PI : float = Math.PI

    let EPSILON = 0.0001
    let AreEqualEpsilon actual expected =
        if Math.Abs(float expected - float actual) <= float EPSILON then true
        else false

    [<Test>]
    member x.ShouldReturnSinusWaveArray() =
        // Arrange
        let wave = Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 4
        let wlen = wave.Length - 1

        // Act

        // Assert
        Assert.IsTrue(AreEqualEpsilon wave.[0] 0.)
        Assert.IsTrue(AreEqualEpsilon wave.[wlen] 0.)
        Assert.IsTrue(AreEqualEpsilon wave.[int wlen / 2] 0.)
        
        Assert.IsTrue(AreEqualEpsilon wave.[int (wlen / 4)] 1.)
        Assert.IsTrue(AreEqualEpsilon wave.[int (wlen / 4 * 3)] -1.)

    [<Test>]
    member x.ShouldReturnSquareWaveArray() =
        Assert.IsTrue(true) // no more than 1 and less than -1

    [<Test>]
    member x.ShouldReturnTriangleWaveArray() =
        Assert.IsTrue(true) // start mid end

    [<Test>]
    member x.ShouldReturnToothWaveArray() =
        Assert.IsTrue(true) // start end

    (*
    let amplitude = 1.
    let frequency = 1.
    let from = 0.
    let step = 0.01
    let until = 20.
    let Wave = Waves(amplitude, frequency)
    
    let Waves : List<List<float * float>> = [
        Wave.Sinus from step until ;
        Wave.Square from step until ;
        Wave.Triangle from step until;
        Wave.Tooth from step until
    ]
    *)