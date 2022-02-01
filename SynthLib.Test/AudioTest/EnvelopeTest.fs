namespace SynthLib.Test.AudioTest
open System
open NUnit.Framework
open SynthLib
open SynthLib.Variables
open SynthLib.Audio
open System

[<TestFixture>]
type EnvelopeTest() = 


    [<Test>]
    member x.TestAttack() =


        let attackTime = 0.1
        let decayTime = 0.03
        let releaseTime = 0.1
        let sustainAmplitude = 0.8


        let enveloppedWave = Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 4 |> Envelope.apply attackTime decayTime releaseTime sustainAmplitude
        let pureWave = Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 4

        let attackTimeSample = int(attackTime * (float enveloppedWave.Length))

        let mutable assertValueA = false

        if abs(enveloppedWave.[attackTimeSample]) > 0.8 * abs(pureWave.[attackTimeSample]) then assertValueA <- true     

        Assert.AreEqual(true,assertValueA)


    [<Test>]
    member x.TestDecay() =


        let attackTime = 0.1
        let decayTime = 0.03
        let releaseTime = 0.1
        let sustainAmplitude = 0.8


        let enveloppedWave = Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 4 |> Envelope.apply attackTime decayTime releaseTime sustainAmplitude
        let pureWave = Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 4

        let attackTimeSample = int(attackTime * (float enveloppedWave.Length))
        let decayTimeSample = int(decayTime * (float enveloppedWave.Length))

        let mutable assertValueD = false


        if abs(enveloppedWave.[attackTimeSample+decayTimeSample]) <= 0.8 * abs(pureWave.[attackTimeSample+decayTimeSample]) then assertValueD <- true
    
        Assert.AreEqual(true,assertValueD)
        


    [<Test>]
    member x.TestSustain() =


        let attackTime = 0.1
        let decayTime = 0.03
        let releaseTime = 0.1
        let sustainAmplitude = 0.8


        let enveloppedWave = Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 4 |> Envelope.apply attackTime decayTime releaseTime sustainAmplitude
        let pureWave = Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 4

        let attackTimeSample = int(attackTime * (float enveloppedWave.Length))
        let decayTimeSample = int(decayTime * (float enveloppedWave.Length))

        let mutable assertValueS = false


        if abs(enveloppedWave.[attackTimeSample+decayTimeSample+10]) < abs(pureWave.[attackTimeSample+decayTimeSample+10]) then assertValueS <- true

        Assert.AreEqual(true,assertValueS)
        

    [<Test>]
    member x.TestRelease() =


        let attackTime = 0.1
        let decayTime = 0.03
        let releaseTime = 0.1
        let sustainAmplitude = 0.8


        let pureWave = Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 4
        let enveloppedWave = Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 4 |> Envelope.apply attackTime decayTime releaseTime sustainAmplitude

        let releaseTimeSample =  int(releaseTime * (float enveloppedWave.Length))

        let mutable assertValueR = false


        if abs(enveloppedWave.[enveloppedWave.Length-(releaseTimeSample/2)]) < abs(pureWave.[enveloppedWave.Length-(releaseTimeSample/2)]) then assertValueR <- true
            

        Assert.AreEqual(true,assertValueR)
