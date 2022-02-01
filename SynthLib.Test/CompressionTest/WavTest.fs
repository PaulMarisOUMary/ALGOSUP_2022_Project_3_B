namespace SynthLib.Test.CompressionTest

open System
open NUnit.Framework
open SynthLib.Compression.Wav
open SynthLib.Audio.Wave
open SynthLib.Audio

[<TestFixture>]
type WavTest() = 

    [<Test>]
    member x.ToByteArray() =
        let wavetestsquare = ToByteArray([1.;1.;-1.;-1.])
        let expected1 = [|255uy;127uy;255uy;127uy;1uy;128uy;1uy;128uy|]
        Assert.AreEqual(expected1,wavetestsquare)


