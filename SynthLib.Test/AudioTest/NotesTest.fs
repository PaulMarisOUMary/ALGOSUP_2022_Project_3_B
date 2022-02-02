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
        Assert.IsTrue(Note.GetFrequency Note.C 0 = 16.351875)
        Assert.IsTrue(Note.GetFrequency Note.D 1 = 36.7075)
        Assert.IsTrue(Note.GetFrequency Note.E 2 = 82.4075)
        Assert.IsTrue(Note.GetFrequency Note.Fs 4 = 369.99)
        Assert.IsTrue(Note.GetFrequency Note.G 6 = 1568.)
        Assert.IsTrue(Note.GetFrequency Note.As 7 = 3729.28)
        Assert.IsTrue(Note.GetFrequency Note.B 8 = 7902.08)