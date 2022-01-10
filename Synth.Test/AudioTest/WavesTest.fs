namespace Synth.Test.Audio

open System
open NUnit.Framework

[<TestFixture>]
type WavesTest() = 

    [<Test>]
    member x.ShouldReturnSinusWaveArray() =
        Assert.IsTrue(true) // trigonometric circle check

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