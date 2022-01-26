namespace SynthLib.Core.Songs

open SynthLib
open SynthLib.Audio

module ExampleSongs =

    let note lenght note octave =
        Wave.MakeNote Wave.Square lenght note octave
        |> Envelope.apply 0.20 0.1 0.45 0.8
        |> Filter.Flange

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


    let MarioTheme () : float list = 
        seq {
            
            yield! note 1. Note.REST 4

            yield! Wave.Combine ([ note 0.15 Note.Fs 4; note 0.15 Note.E 4 ])
            yield! Wave.Combine ([ note 0.15 Note.Fs 4; note 0.15 Note.E 4 ])
            yield! note 0.15 Note.REST 4
            yield! Wave.Combine ([ note 0.15 Note.Fs 4; note 0.15 Note.E 4 ])
            yield! note 0.15 Note.REST 4
            yield! Wave.Combine ([ note 0.15 Note.Fs 4; note 0.15 Note.C 4 ])
            yield! Wave.Combine ([ note 0.3 Note.Fs 4; note 0.3 Note.E 4 ])

            yield! Wave.Combine ([ note 0.3 Note.G 4; note 0.3 Note.B 4; note 0.3 Note.G 5])
            yield! note 0.3 Note.REST 4
            yield! note 0.3 Note.G 4
            yield! note 0.3 Note.REST 4

            yield! Wave.Combine ([ note 0.3 Note.E 4; note 0.3 Note.C 5])
            yield! note 0.15 Note.REST 4
            yield! Wave.Combine ([ note 0.3 Note.C 4; note 0.3 Note.G 4])
            yield! note 0.15 Note.REST 4
            yield! Wave.Combine ([ note 0.3 Note.G 3; note 0.3 Note.E 4])
            yield! note 0.15 Note.REST 4

            yield! Wave.Combine ([ note 0.3 Note.C 4; note 0.3 Note.A 4])
            yield! Wave.Combine ([ note 0.3 Note.D 4; note 0.3 Note.B 4])
            yield! Wave.Combine ([ note 0.15 Note.Cs 4; note 0.15 Note.As 4])
            yield! Wave.Combine ([ note 0.3 Note.C 4; note 0.3 Note.A 4])

            yield! Wave.Combine ([ note 0.25 Note.C 4; note 0.25 Note.G 4])
            yield! Wave.Combine ([ note 0.25 Note.G 4; note 0.25 Note.E 5])
            yield! Wave.Combine ([ note 0.25 Note.B 4; note 0.25 Note.G 5])
            yield! Wave.Combine ([ note 0.3 Note.C 5; note 0.3 Note.A 5])
            yield! Wave.Combine ([ note 0.15 Note.A 4; note 0.15 Note.F 5])
            yield! Wave.Combine ([ note 0.15 Note.B 4; note 0.15 Note.G 5])

            yield! note 0.15 Note.REST 4
            yield! Wave.Combine ([ note 0.3 Note.A 4; note 0.3 Note.E 5])
            yield! Wave.Combine ([ note 0.15 Note.E 4; note 0.15 Note.C 5])
            yield! Wave.Combine ([ note 0.15 Note.F 4; note 0.15 Note.D 5])
            yield! Wave.Combine ([ note 0.3 Note.D 4; note 0.3 Note.B 4])

            yield! Wave.Combine ([ note 0.3 Note.E 4; note 0.3 Note.C 5])
            yield! note 0.15 Note.REST 4
            yield! Wave.Combine ([ note 0.3 Note.C 4; note 0.3 Note.G 4])
            yield! note 0.15 Note.REST 4
            yield! Wave.Combine ([ note 0.3 Note.G 3; note 0.3 Note.E 4])
            yield! note 0.15 Note.REST 4

            yield! Wave.Combine ([ note 0.3 Note.C 4; note 0.3 Note.A 4])
            yield! Wave.Combine ([ note 0.3 Note.D 4; note 0.3 Note.B 4])
            yield! Wave.Combine ([ note 0.15 Note.Cs 4; note 0.15 Note.As 4])
            yield! Wave.Combine ([ note 0.3 Note.C 4; note 0.3 Note.A 4])

            yield! Wave.Combine ([ note 0.25 Note.C 4; note 0.25 Note.G 4])
            yield! Wave.Combine ([ note 0.25 Note.G 4; note 0.25 Note.E 5])
            yield! Wave.Combine ([ note 0.25 Note.B 4; note 0.25 Note.G 5])
            yield! Wave.Combine ([ note 0.3 Note.C 5; note 0.3 Note.A 5])
            yield! Wave.Combine ([ note 0.15 Note.A 4; note 0.15 Note.F 5])
            yield! Wave.Combine ([ note 0.15 Note.B 4; note 0.15 Note.G 5])

            yield! note 0.15 Note.REST 4

            yield! Wave.Combine ([ note 0.3 Note.A 4; note 0.3 Note.E 5])
            yield! Wave.Combine ([ note 0.15 Note.E 4; note 0.15 Note.C 5])
            yield! Wave.Combine ([ note 0.15 Note.F 4; note 0.15 Note.D 5])
            yield! Wave.Combine ([ note 0.3 Note.D 4; note 0.3 Note.B 4])

            yield! note 0.15 Note.REST 4

//-------------------------------------------------------------------
            for i in 0..1 do
                yield! note 0.3 Note.REST 4

                yield! Wave.Combine ([ note 0.15 Note.E 5; note 0.15 Note.G 5])
                yield! Wave.Combine ([ note 0.15 Note.Ds 5; note 0.15 Note.Fs 5])
                yield! Wave.Combine ([ note 0.15 Note.D 5; note 0.15 Note.F 5])
                yield! Wave.Combine ([ note 0.3 Note.B 4; note 0.3 Note.Ds 5])
                yield! Wave.Combine ([ note 0.15 Note.C 5; note 0.15 Note.E 5])
                
                yield! note 0.15 Note.REST 4
                
                yield! Wave.Combine ([ note 0.15 Note.E 4; note 0.15 Note.Gs 4])
                yield! Wave.Combine ([ note 0.15 Note.F 4; note 0.15 Note.A 4])
                yield! Wave.Combine ([ note 0.15 Note.G 4; note 0.15 Note.C 4])

                yield! note 0.15 Note.REST 4

                yield! Wave.Combine ([ note 0.15 Note.C 4; note 0.15 Note.A 4])
                yield! Wave.Combine ([ note 0.15 Note.E 4; note 0.15 Note.C 5])
                yield! Wave.Combine ([ note 0.15 Note.F 4; note 0.15 Note.D 5])

                yield! note 0.3 Note.REST 4

                yield! Wave.Combine ([ note 0.15 Note.E 5; note 0.15 Note.G 5])
                yield! Wave.Combine ([ note 0.15 Note.Ds 5; note 0.15 Note.Fs 5])
                yield! Wave.Combine ([ note 0.15 Note.D 5; note 0.15 Note.F 5])
                yield! Wave.Combine ([ note 0.3 Note.B 4; note 0.3 Note.Ds 5])
                yield! Wave.Combine ([ note 0.15 Note.C 5; note 0.15 Note.E 5])

                yield! note 0.15 Note.REST 4

                yield! Wave.Combine ([ note 0.3 Note.F 5; note 0.3 Note.G 5; note 0.3 Note.C 6])
                yield! Wave.Combine ([ note 0.15 Note.F 5; note 0.15 Note.G 5; note 0.15 Note.C 6])
                yield! Wave.Combine ([ note 0.3 Note.F 5; note 0.3 Note.G 5; note 0.3 Note.C 6])

                yield! note 0.3 Note.REST 4

                yield! Wave.Combine ([ note 0.15 Note.E 5; note 0.15 Note.G 5])
                yield! Wave.Combine ([ note 0.15 Note.Ds 5; note 0.15 Note.Fs 5])
                yield! Wave.Combine ([ note 0.15 Note.D 5; note 0.15 Note.F 5])
                yield! Wave.Combine ([ note 0.3 Note.B 4; note 0.3 Note.Ds 5])
                yield! Wave.Combine ([ note 0.15 Note.C 5; note 0.15 Note.E 5])
                
                yield! note 0.15 Note.REST 4
                
                yield! Wave.Combine ([ note 0.15 Note.E 4; note 0.15 Note.Gs 4])
                yield! Wave.Combine ([ note 0.15 Note.F 4; note 0.15 Note.A 4])
                yield! Wave.Combine ([ note 0.15 Note.G 4; note 0.15 Note.C 4])

                yield! note 0.15 Note.REST 4

                yield! Wave.Combine ([ note 0.15 Note.C 4; note 0.15 Note.A 4])
                yield! Wave.Combine ([ note 0.15 Note.E 4; note 0.15 Note.C 5])
                yield! Wave.Combine ([ note 0.15 Note.F 4; note 0.15 Note.D 5])

                yield! note 0.3 Note.REST 4

                yield! Wave.Combine ([ note 0.3 Note.Gs 4; note 0.3 Note.Ds 5])
                yield! note 0.15 Note.REST 4
                yield! Wave.Combine ([ note 0.3 Note.F 4; note 0.3 Note.D 5])
                yield! note 0.15 Note.REST 4
                yield! Wave.Combine ([ note 0.3 Note.E 4; note 0.3 Note.C 5])

                yield! note 0.3 Note.REST 4


            yield! note 1.2 Note.REST 4


        } |> Seq.toList

(*
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
*)
(*
    let Zelda () : float list =
        let mutable MainTheme = note halfNote Note.REST 0

        MainTheme <- MainTheme @ note fullNote Note.C 4
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.As 3
        MainTheme <- MainTheme @ note eightNote Note.Gs 3
        MainTheme <- MainTheme @ note fullNote125 Note.As 3
        MainTheme <- MainTheme @ note fullNote Note.C 4
        MainTheme <- MainTheme @ note quarterNote Note.Gs 3
        MainTheme <- MainTheme @ note quarterNote Note.Gs 3
        MainTheme <- MainTheme @ note quarterNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.B 3
        MainTheme <- MainTheme @ note eightNote Note.A 3
        MainTheme <- MainTheme @ note fullNote125 Note.B 3
        MainTheme <- MainTheme @ note eightNote Note.REST 0
        MainTheme <- MainTheme @ note quarterNote Note.Ds 2
        MainTheme <- MainTheme @ note halfNote Note.REST 0
        MainTheme <- MainTheme @ note quarterNote Note.Ds 2
        MainTheme <- MainTheme @ note halfNote Note.REST 0
        MainTheme <- MainTheme @ note halfNote Note.C 4
        MainTheme <- MainTheme @ note halfNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.REST 0
        MainTheme <- MainTheme @ note quarterNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.375 Note.G 4
        MainTheme <- MainTheme @ note fullNote Note.REST 0
        MainTheme <- MainTheme @ note 0.375 Note.C 4
        MainTheme <- MainTheme @ note halfNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.375 Note.G 4
        MainTheme <- MainTheme @ note fullNote Note.REST 0
        MainTheme <- MainTheme @ note 0.375 Note.C 4
        MainTheme <- MainTheme @ note halfNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note note 0.0625 Note.REST 0
        MainTheme <- MainTheme @ note quarterNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.Gs 4
        MainTheme <- MainTheme @ note eightNote Note.As 4
        MainTheme <- MainTheme @ note 0.75 Note.C 5
        MainTheme <- MainTheme @ note note 0.0625 Note.REST 0
        MainTheme <- MainTheme @ note eightNote Note.C 5
        MainTheme <- MainTheme @ note eightNote Note.C 5
        MainTheme <- MainTheme @ note eightNote Note.As 4
        MainTheme <- MainTheme @ note eightNote Note.Gs 4
        MainTheme <- MainTheme @ note quarterNote Note.As 4
        MainTheme <- MainTheme @ note eightNote Note.Gs 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note note 0.0625 Note.REST 0
        MainTheme <- MainTheme @ note halfNote Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.F 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.75 Note.Gs 4
        MainTheme <- MainTheme @ note 0.375 Note.G 4
        MainTheme <- MainTheme @ note 0.375 Note.F 4
        MainTheme <- MainTheme @ note quarterNote Note.Ds 4
        MainTheme <- MainTheme @ note eightNote Note.Ds 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.F 4
        MainTheme <- MainTheme @ note quarterNote Note.Ds 4
        MainTheme <- MainTheme @ note quarterNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note 0.75 Note.Fs 4
        MainTheme <- MainTheme @ note halfNote Note.A 4
        MainTheme <- MainTheme @ note quarterNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note 0.375 Note.C 4
        MainTheme <- MainTheme @ note halfNote Note.G 3 
        MainTheme <- MainTheme @ note quarterNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note note 0.0625 Note.REST 0
        MainTheme <- MainTheme @ note quarterNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.Gs 4
        MainTheme <- MainTheme @ note eightNote Note.As 4
        MainTheme <- MainTheme @ note 0.75 Note.C 5
        MainTheme <- MainTheme @ note quarterNote Note.Ds 5
        MainTheme <- MainTheme @ note quarterNote Note.D 5
        MainTheme <- MainTheme @ note quarterNote Note.B 4
        MainTheme <- MainTheme @ note eightNote Note.G 4
        MainTheme <- MainTheme @ note 0.75 Note.Gs 4
        MainTheme <- MainTheme @ note quarterNote Note.C 5
        MainTheme <- MainTheme @ note quarterNote Note.B 4
        MainTheme <- MainTheme @ note 0.375 Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.G 4
        MainTheme <- MainTheme @ note 0.75 Note.Gs 4
        MainTheme <- MainTheme @ note quarterNote Note.C 5
        MainTheme <- MainTheme @ note quarterNote Note.B 4
        MainTheme <- MainTheme @ note 0.375 Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.E 4
        MainTheme <- MainTheme @ note 0.75 Note.F 4
        MainTheme <- MainTheme @ note halfNote Note.Gs 4
        MainTheme <- MainTheme @ note halfNote Note.G 4
        MainTheme <- MainTheme @ note 0.75 Note.Ds 4
        MainTheme <- MainTheme @ note halfNote Note.C 4
        MainTheme <- MainTheme @ note quarterNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note 0.75 Note.Fs 4
        MainTheme <- MainTheme @ note halfNote Note.A 4
        MainTheme <- MainTheme @ note quarterNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note 0.375 Note.C 4
        MainTheme <- MainTheme @ note 0.375 Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.REST 0
        MainTheme <- MainTheme @ note quarterNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note fullNote Note.REST 0
        MainTheme <- MainTheme @ note halfNote Note.C 4
        MainTheme <- MainTheme @ note 0.625 Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.REST 0
        MainTheme <- MainTheme @ note quarterNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note fullNote Note.REST 0
        MainTheme <- MainTheme @ note halfNote Note.C 4
        MainTheme <- MainTheme @ note 0.625 Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.Gs 4
        MainTheme <- MainTheme @ note eightNote Note.As 4
        MainTheme <- MainTheme @ note 0.75 Note.C 5
        MainTheme <- MainTheme @ note eightNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.As 4
        MainTheme <- MainTheme @ note eightNote Note.Gs 4
        MainTheme <- MainTheme @ note note 0.1825 Note.As 4
        MainTheme <- MainTheme @ note eightNote Note.Gs 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note halfNote Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.F 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note eightNote Note.G 4
        MainTheme <- MainTheme @ note 0.75 Note.Gs 4
        MainTheme <- MainTheme @ note quarterNote Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.F 4
        MainTheme <- MainTheme @ note quarterNote Note.Ds 4
        MainTheme <- MainTheme @ note eightNote Note.Ds 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.F 4
        MainTheme <- MainTheme @ note quarterNote Note.Ds 4
        MainTheme <- MainTheme @ note quarterNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note 0.75 Note.Fs 4
        MainTheme <- MainTheme @ note halfNote Note.A 4
        MainTheme <- MainTheme @ note quarterNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note halfNote Note.C 4
        MainTheme <- MainTheme @ note 0.75 Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.C 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note eightNote Note.F 4
        MainTheme <- MainTheme @ note 0.75 Note.G 4
        MainTheme <- MainTheme @ note quarterNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.Gs 4
        MainTheme <- MainTheme @ note eightNote Note.As 4
        MainTheme <- MainTheme @ note 0.75 Note.C 4
        MainTheme <- MainTheme @ note halfNote Note.D 4
        MainTheme <- MainTheme @ note halfNote Note.Ds 4
        MainTheme <- MainTheme @ note 0.625 Note.B 4
        MainTheme <- MainTheme @ note 0.375 Note.G 4
        MainTheme <- MainTheme @ note 0.75 Note.Gs 4
        MainTheme <- MainTheme @ note halfNote Note.C 5
        MainTheme <- MainTheme @ note halfNote Note.B 4
        MainTheme <- MainTheme @ note 0.625 Note.G 4
        MainTheme <- MainTheme @ note halfNote Note.G 4
        MainTheme <- MainTheme @ note 0.75 Note.Gs 4
        MainTheme <- MainTheme @ note halfNote Note.C 4
        MainTheme <- MainTheme @ note halfNote Note.B 4
        MainTheme <- MainTheme @ note 0.625 Note.G 4
        MainTheme <- MainTheme @ note halfNote Note.E 4
        MainTheme <- MainTheme @ note 0.625 Note.F 4
        MainTheme <- MainTheme @ note halfNote Note.Gs 4
        MainTheme <- MainTheme @ note halfNote Note.G 4
        MainTheme <- MainTheme @ note 0.625 Note.Ds 4
        MainTheme <- MainTheme @ note halfNote Note.C 4
        MainTheme <- MainTheme @ note quarterNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.D 4
        MainTheme <- MainTheme @ note eightNote Note.E 4
        MainTheme <- MainTheme @ note 0.625 Note.Fs 4
        MainTheme <- MainTheme @ note halfNote Note.A 4
        MainTheme <- MainTheme @ note quarterNote Note.G 4
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note eightNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note quarterNote Note.G 3
        MainTheme <- MainTheme @ note 0.825 Note.C 4

        MainTheme

        
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

    *)
    let Through() : float list = 
        let mutable ThroughFireAndFlames = note 0.1 Note.REST 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.As 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.As 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.As 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.As 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.As 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3


        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 3



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.As 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.As 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.15 Note.As 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.15 Note.C 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.As 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4






        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        //

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        
        
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        
        
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.3 Note.G 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        //

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        
        
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        
        
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Ds 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Gs 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Fs 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Fs 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Fs 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Fs 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Fs 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.Fs 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ note 0.3 Note.Fs 5


        ThroughFireAndFlames