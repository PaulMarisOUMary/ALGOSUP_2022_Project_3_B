namespace SynthLib.Core

open System
open SynthLib.Variables
open SynthLib.Compression
open SynthLib.Core.Songs.ExampleSongs
open SynthLib.Audio

module Program =
    [<EntryPoint>]
    let main _  =

        // set Synth.Variables : samplerate env variable to true to save .wav
        let bitarray = Titanic |> Wav.ToByteArray

        Wav.EncodeWav @"../../../../test.wav" bitarray

        0