namespace Synth

open Synth
open Variables

module Program =
    [<EntryPoint>]
    let main _  =

        let Waves : List<List<float>> = [
            Wave.MakeNote (Wave.Sawtooth) 1. Note.DEBUG 4
        ]
        
        //Synth.Visualization.Chart Waves 1200 250

        let mutable MoonTune = Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0

        for i in 0 .. 8 do
            MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C i
            MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D i 
            MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.E i
            MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.F i
            MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.G i
            MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.A i
            MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.B i |> Filter.Amplitude 5.

        // set Synth.Variables : samplerate env variable to true to save .Wav
        let bitarray = MoonTune |> List.map (fun (x:float) -> int16 (x * 32767.)) |> List.map(fun x -> System.BitConverter.GetBytes(x)) |>  List.reduce Array.append

        Wav.EncodeWav @"../../../test.wav" bitarray
        

        //use buffer = new SFML.Audio.SoundBuffer(bitarray,uint32 1,uint32 sampleRate)
        //use sound = new SFML.Audio.Sound(buffer)
        //sound.Loop <- true
        //sound.Play()
        //System.Console.Read()


        0