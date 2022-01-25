namespace SynthLib.Core.Songs

open SynthLib
open SynthLib.Audio

module ExampleSongs =

    let note lenght note octave =
        Wave.MakeNote Wave.Square lenght note octave
        |> Envelope.apply 0.1 0.01 0.1 0.8

    let fullNote = note 1.
    let halfNote = note 0.5
    let quarterNote = note 0.25
    let eightNote = note 0.125

    let MoonSong () : float list =
        seq {
            yield! halfNote Note.C 4
            yield! halfNote Note.C 4
            yield! halfNote Note.C 4
            yield! halfNote Note.D 4
            yield! fullNote Note.E 4
            yield! fullNote Note.D 4
            yield! halfNote Note.C 4
            yield! halfNote Note.E 4
            yield! halfNote Note.D 4
            yield! halfNote Note.D 4
            yield! fullNote Note.C 4
            yield! fullNote Note.REST 4
        } |> Seq.toList

    let PirateOfCaraiban () : float list =
        seq {
            yield! quarterNote Note.D 4
            yield! halfNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.A 3
            yield! eightNote Note.C 4
            yield! quarterNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.E 4
            yield! quarterNote Note.F 4
            yield! quarterNote Note.F 4
            yield! eightNote Note.F 4
            yield! eightNote Note.G 4
            yield! quarterNote Note.E 4
            yield! quarterNote Note.E 4
            yield! eightNote Note.D 4
            yield! eightNote Note.C 4
            yield! eightNote Note.C 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.REST 0
            yield! eightNote Note.A 3
            yield! eightNote Note.C 4
            yield! quarterNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.E 4
            yield! quarterNote Note.F 4
            yield! quarterNote Note.F 4
            yield! eightNote Note.F 4
            yield! eightNote Note.G 4
            yield! quarterNote Note.E 4
            yield! quarterNote Note.E 4
            yield! eightNote Note.D 4
            yield! eightNote Note.C 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.REST 0
            yield! eightNote Note.A 3
            yield! eightNote Note.C 4
            yield! quarterNote Note.D 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.D 4
            yield! eightNote Note.F 4
            yield! quarterNote Note.G 4
            yield! quarterNote Note.G 4
            yield! eightNote Note.G 4
            yield! eightNote Note.A 4
            yield! quarterNote Note.As 4
            yield! quarterNote Note.As 4
            yield! eightNote Note.A 4
            yield! eightNote Note.G 4
            yield! eightNote Note.A 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.REST 0
            yield! eightNote Note.D 4
            yield! eightNote Note.E 4
            yield! quarterNote Note.F 4
            yield! quarterNote Note.F 4
            yield! quarterNote Note.G 4
            yield! eightNote Note.A 4
            yield! quarterNote Note.D 4
            yield! eightNote Note.REST 0
            yield! eightNote Note.D 4
            yield! eightNote Note.F 4
            yield! quarterNote Note.E 4
            yield! quarterNote Note.E 4
            yield! eightNote Note.F 4
            yield! eightNote Note.D 4
            yield! quarterNote Note.E 4
            yield! quarterNote Note.REST 0
            yield! eightNote Note.A 4
            yield! eightNote Note.C 5
            yield! quarterNote Note.D 5
            yield! quarterNote Note.D 5
            yield! eightNote Note.D 5
            yield! eightNote Note.E 5
            yield! quarterNote Note.F 5
            yield! quarterNote Note.F 5
            yield! eightNote Note.F 5
            yield! eightNote Note.G 5
            yield! quarterNote Note.E 5
            yield! quarterNote Note.E 5
            yield! eightNote Note.D 5
            yield! eightNote Note.C 5
            yield! eightNote Note.C 5
            yield! quarterNote Note.D 5
            yield! eightNote Note.REST 0
            yield! eightNote Note.A 4
            yield! eightNote Note.C 5
            yield! quarterNote Note.D 5
            yield! quarterNote Note.D 5
            yield! eightNote Note.D 5
            yield! eightNote Note.E 5
            yield! quarterNote Note.F 5
            yield! quarterNote Note.F 5
            yield! eightNote Note.F 5
            yield! eightNote Note.G 5
            yield! quarterNote Note.E 5
            yield! quarterNote Note.E 5
            yield! eightNote Note.D 5
            yield! eightNote Note.C 5 
            yield! quarterNote Note.D 5
            yield! quarterNote Note.REST 0
            yield! eightNote Note.A 4
            yield! eightNote Note.C 5
            yield! quarterNote Note.D 5
            yield! quarterNote Note.D 5
            yield! eightNote Note.D 5
            yield! eightNote Note.F 5
            yield! quarterNote Note.G 5
            yield! quarterNote Note.G 5
            yield! eightNote Note.G 5
            yield! eightNote Note.A 5
            yield! quarterNote Note.As 5
            yield! quarterNote Note.As 5
            yield! eightNote Note.A 5
            yield! eightNote Note.G 5
            yield! eightNote Note.A 5
            yield! quarterNote Note.D 5
            yield! eightNote Note.REST 0
            yield! eightNote Note.D 5
            yield! eightNote Note.E 5
            yield! quarterNote Note.F 5
            yield! quarterNote Note.F 5
            yield! quarterNote Note.G 5
            yield! eightNote Note.A 5
            yield! quarterNote Note.D 5
            yield! eightNote Note.REST 0
            yield! eightNote Note.D 5
            yield! eightNote Note.F 5
            yield! quarterNote Note.E 5
            yield! quarterNote Note.E 5
            yield! eightNote Note.D 5
            yield! eightNote Note.C 5
            yield! quarterNote Note.D 5
            yield! quarterNote Note.D 5
            yield! quarterNote Note.E 5
            yield! quarterNote Note.F 5
            yield! eightNote Note.F 5
            yield! eightNote Note.F 5
            yield! quarterNote Note.G 5
            yield! fullNote Note.A 5
            yield! eightNote Note.F 5
            yield! eightNote Note.D 5
            yield! note 0.8 Note.A 4
    
        }|>Seq.toList

     
    let Doom () : float list =
        
        seq{

            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.A 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.As 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.Ds 3
            yield! halfNote Note.A 3
        
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.A 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.As 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.Ds 3
            yield! halfNote Note.A 3

            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.A 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.As 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.Ds 3
            yield! halfNote Note.A 3

            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.A 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.As 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3

            yield! note 0.0625 Note.F 5
            yield! note 0.0625 Note.Ds 5
            yield! note 0.0625 Note.F 5
            yield! note 0.0625 Note.Fs 5
            yield! note 0.0625 Note.D 5
            yield! note 0.0625 Note.Fs 5
            yield! note 0.0625 Note.As 5
            yield! note 0.0625 Note.Fs 5
            yield! note 0.0625 Note.D 5

            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.A 3
            yield! quarterNote Note.D 3
            yield! eightNote Note.As 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! halfNote Note.A 3

            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.A 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.As 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.Ds 3
            yield! halfNote Note.A 3

            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.A 3
            yield! quarterNote Note.Ds 3
            yield! eightNote Note.As 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3

            yield! eightNote Note.As 5
            yield! eightNote Note.Fs 5
            yield! eightNote Note.As 5
            yield! eightNote Note.Fs 5
            yield! eightNote Note.Ds 6
            yield! eightNote Note.Fs 5
            yield! eightNote Note.As 5
            yield! eightNote Note.Ds 6

            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Fs 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.E 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.D 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.E 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Fs 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.E 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! halfNote Note.D 4

            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Fs 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.E 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.D 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.E 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 4
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Gs 3
            yield! eightNote Note.Fs 4
            yield! eightNote Note.Fs 3
            yield! eightNote Note.Fs 3

            yield! note 0.0625 Note.Ds 5
            yield! note 0.0625 Note.Cs 5
            yield! note 0.0625 Note.Ds 5
            yield! note 0.0625 Note.B 4
            yield! note 0.0625 Note.Gs 5
            yield! note 0.0625 Note.Ds 5
            yield! note 0.0625 Note.Ds 5
            yield! note 0.0625 Note.Gs 4

            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.A 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.As 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Cs 4
            yield! eightNote Note.Ds 3
            yield! eightNote Note.Ds 3
            yield! eightNote Note.B 3
            yield! eightNote Note.Ds 3
            yield! quarterNote Note.Ds 3
            yield! halfNote Note.A 3

        }|>Seq.toList

(*
    let Zelda () : float list =
        let mutable MainTheme = Wave.MakeNote (Wave.Sine) halfNote Note.REST 0

        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) fullNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.As 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Gs 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) fullNote125 Note.As 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) fullNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.Gs 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.Gs 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.B 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.A 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) fullNote125 Note.B 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.Ds 2
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.Ds 2
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) fullNote Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) fullNote Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) note 0.0625 Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.As 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) note 0.0625 Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.As 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.As 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) note 0.0625 Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.Ds 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Ds 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.Ds 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Fs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.A 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.G 3 
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) note 0.0625 Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.As 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.Ds 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.D 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Ds 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Fs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.A 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) fullNote Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) fullNote Note.REST 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.As 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.As 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) note 0.1825 Note.As 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.Ds 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Ds 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.Ds 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Fs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.A 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.As 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.Ds 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.Gs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.Ds 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.Fs 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) halfNote Note.A 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) eightNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) quarterNote Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.825 Note.C 4

        MainTheme

        *)
    let Thunder() : float list =
        seq {
            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.G 5
            yield! eightNote Note.B 4
        
            yield! eightNote Note.B 5
            yield! eightNote Note.B 4
            yield! eightNote Note.A 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Gs 5
            yield! eightNote Note.B 4
            yield! eightNote Note.A 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Gs 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4

            yield! eightNote Note.B 5
            yield! eightNote Note.B 4

            yield! eightNote Note.A 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Gs 5
            yield! eightNote Note.B 4
            yield! eightNote Note.A 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Gs 5
            yield! eightNote Note.B 4

            yield! eightNote Note.Fs 5
            yield! eightNote Note.B 4
            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4

            yield! eightNote Note.E 5
            yield! eightNote Note.B 4
            yield! eightNote Note.Ds 5
            yield! eightNote Note.B 4

        } |> Seq.toList

    (*
    let Through() : float list = 
        
        seq{
            yield! note 0.1 Note.REST 4

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.As 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.D 4
            yield! note 0.1 Note.G 3

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.As 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.D 4
            yield! note 0.1 Note.G 3

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.As 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.D 4
            yield! note 0.1 Note.G 3

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.As 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.D 4
            yield! note 0.1 Note.G 3

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.As 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.D 4
            yield! note 0.1 Note.G 3

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 3
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 3

            yield! note 0.1 Note.As 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.As 4
            yield! note 0.2 Note.As 4
            yield! note 0.2 Note.C 5
            yield! note 0.1 Note.As 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
        
            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4
        
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4        

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
        
            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4
        
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4
        
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
        
            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4
        
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4
        
            yield! note 0.1 Note.D 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.F 4
            yield! note 0.4 Note.G 4

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
        
            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4
        
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4 

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4
        
            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4
        
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.Ds 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4
        
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4

            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.F 4

            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.C 4       
        
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.C 4
            yield! note 0.1 Note.D 4
            yield! note 0.1 Note.Ds 4
            yield! note 0.1 Note.F 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 4
            yield! note 0.1 Note.Gs 4
            yield! note 0.1 Note.G 4

            yield! note 0.1 Note.G 5
            yield! note 0.1 Note.Fs 5
            yield! note 0.1 Note.G 5
            yield! note 0.1 Note.Fs 5
            yield! note 0.1 Note.G 5
            yield! note 0.1 Note.Fs 5
            yield! note 0.1 Note.G 5
            yield! note 0.1 Note.Fs 5
            yield! note 0.1 Note.G 5
            yield! note 0.1 Note.Fs 5
            yield! note 0.1 Note.G 5
            yield! note 0.1 Note.Fs 5
            yield! note 0.1 Note.G 5
            yield! note 0.3 Note.Fs 5

        }|> Seq.toList
        *)
        