namespace SynthLib.Core

open SynthLib.Core.Songs.ExampleSongs

open SynthLib
open SynthLib.Audio
open SynthLib.Compression

module Program =
    [<EntryPoint>]
    let main _  =

        let Waves : List<List<float>> = [
            Wave.MakeNote (Wave.Sawtooth) 1. Note.DEBUG 4
        ]
        
        //Synth.Visualization.Chart Waves 1200 250

        // set Synth.Variables : samplerate env variable to true to save .Wav
        let bitarray = Through()|> List.map (fun (x:float) -> int16 (x * 32767.)) |> List.map(fun x -> System.BitConverter.GetBytes(x)) |>  List.reduce Array.append

        Wav.EncodeWav @"../../../../test.wav" bitarray
        

        //use buffer = new SFML.Audio.SoundBuffer(bitarray,uint32 1,uint32 sampleRate)
        //use sound = new SFML.Audio.Sound(buffer)
        //sound.Loop <- true
        //sound.Play()
        //System.Console.Read()

        0