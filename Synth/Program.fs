namespace Synth

open Synth
open Variables

module Program =
    [<EntryPoint>]
    let main _  =

        let Waves : List<List<float>> = [
            Wave.MakeNote (Wave.Triangle) 1. Note.DEBUG 4
        ]
        
        //Synth.Visualization.Chart Waves 1200 250

        let mutable MoonTune = Wave.MakeNote (Wave.Sine) 0.5 Note.C 4 |> Filter.Echo 360.
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 1. Note.E 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.E 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        

        let bitarray = MoonTune |> List.map (fun (x:float) -> int16 (x * 32767.)) |> List.map(fun x -> System.BitConverter.GetBytes(x)) |>  List.reduce Array.append

        Wav.EncodeWav @"/Users/paulmaris/Desktop/test.wav" bitarray
        

        //use buffer = new SFML.Audio.SoundBuffer(bitarray,uint32 1,uint32 sampleRate)
        //use sound = new SFML.Audio.Sound(buffer)
        //sound.Loop <- true
        //sound.Play()
        //System.Console.Read()


        0