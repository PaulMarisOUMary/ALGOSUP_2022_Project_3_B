namespace SynthLib.Test.AudioTest

open System
open SynthLib.Audio
open NUnit.Framework

[<TestFixture>]
type NoteTest() =

    [<Test>]
    member x.GetFrequencyTest() =
        Assert.IsTrue(Note.GetFrequency Note.REST 4 = 0.)
        Assert.IsTrue(Note.GetFrequency Note.DEBUG 5 = 2.)