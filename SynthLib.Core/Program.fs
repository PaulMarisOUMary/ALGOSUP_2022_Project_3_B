﻿namespace SynthLib.Core

open SynthLib.Compression
open SynthLib.Core.Songs.ExampleSongs

module Program =
    [<EntryPoint>]
    let main _  =

        // Visualize a Chart
        //let Waves : List<List<float>> = [
        //    Wave.MakeNote (Wave.Sawtooth) 1. Note.DEBUG 4
        //]
        //Synth.Visualization.Chart Waves 1200 250


        // set Synth.Variables : samplerate env variable to true to save .Wav
        let bitarray = MoonSong() |> Wav.ToByteArray

        Wav.EncodeWav @"../../../../test.wav" bitarray
        

        //use buffer = new SFML.Audio.SoundBuffer(bitarray,uint32 1,uint32 sampleRate)
        //use sound = new SFML.Audio.Sound(buffer)
        //sound.Loop <- true
        //sound.Play()
        //System.Console.Read()

        0