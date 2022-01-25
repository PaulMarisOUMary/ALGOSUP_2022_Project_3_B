namespace SynthLib.Core

open System
open SynthLib.Variables
open SynthLib.Compression
open SynthLib.Core.Songs.ExampleSongs
open SynthLib.Audio

module Program =
    [<EntryPoint>]
    let main _  =

        // Visualize a Chart
        //let Waves : List<List<float>> = [
        //    Wave.MakeNote (Wave.Sawtooth) 1. Note.DEBUG 4
        //]
        //Synth.Visualization.Chart Waves 1200 250


        // set Synth.Variables : samplerate env variable to true to save .Wav
        //let bitarray = SynthLib.Audio.Wave.Combine([Wave.MakeNote (Wave.Square) 2. Note.E 4; Wave.MakeNote (Wave.Square) 2. Note.C 4]) |> Wav.ToByteArray

        //Wav.EncodeWav @"../../../../test.wav" bitarray
        

        let bitarray = Doom() |> List.map (fun (x:float) -> int16 (x * 32767.)) |> List.toArray

        use buffer = new SFML.Audio.SoundBuffer(bitarray,uint32 1,uint32 sampleRate)
        use sound = new SFML.Audio.Sound(buffer)
        sound.Loop <- true
        sound.Play()
        System.Console.Read()

        0