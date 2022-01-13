namespace Synth

open Synth
open Variables

module Program =
    [<EntryPoint>]
    let main _  =

        let Waves : List<List<float>> = [
            Wave.MakeNote (Wave.Sine) 20. Note.A 4
            Wave.MakeNote (Wave.Triangle) 20. Note.DEBUG 4
            Wave.MakeNote (Wave.Sawtooth) 20. Note.DEBUG 4
            Wave.MakeNote (Wave.Square) 20. Note.DEBUG 4
        ]

        
        //Synth.Visualization.Chart Waves 1200 250

        let mutable MoonTune = Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 1. Note.E 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.E 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        

        let bitarray = MoonTune |> List.map (fun (x:float) -> int16 (x * 32767.)) |> List.toArray

        //use buffer = new SFML.Audio.SoundBuffer(bitarray,uint32 1,uint32 sampleRate)
        //use sound = new SFML.Audio.Sound(buffer)
        //sound.Loop <- true
        //sound.Play()
        //System.Console.Read()


        0