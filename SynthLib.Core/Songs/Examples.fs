namespace SynthLib.Core.Songs

open SynthLib
open SynthLib.Audio

module ExampleSongs =

    let note lenght note octave =
        Wave.MakeNote Wave.Sine lenght note octave

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
        } |> Seq.toList

    let PirateOfCaraiban () : float list =
    
            let mutable HesAPirate = Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
            
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 3
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.E 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 3
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.E 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 3
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.G 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.G 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.Ad 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.Ad 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.E 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.G 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 0
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.E 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.E 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 5 
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 0
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.G 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.G 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.Ad 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.Ad 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.E 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.G 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.E 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 1. Note.G 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 4. Note.A 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.F 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 5
            HesAPirate <- HesAPirate @ Wave.MakeNote (Wave.Sine) 3. Note.A 4
    
            HesAPirate


    let Doom () : float list =
        let mutable AtHellGates = Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.250 Note.A 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 3
        
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.250 Note.A 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 3

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.250 Note.A 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 3

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.250 Note.A 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.F 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Dd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.F 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Fd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.D 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Fd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Ad 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Fd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.D 5

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.A 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.250 Note.D 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 3

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.250 Note.A 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 3

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.A 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Fd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Fd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 6
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Fd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 6

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Fd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Fd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Fd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Fd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Fd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Fd 3

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Dd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Cd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Dd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.B 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Gd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Dd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Dd 5
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.0625 Note.Gd 4

        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.250 Note.A 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Cd 4
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 3
        AtHellGates <- AtHellGates @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 3

        AtHellGates


    let Zelda () : float list =
        let mutable MainTheme = Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0

        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 1. Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 1.125 Note.Ad 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 1. Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.Gd 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.Gd 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.B 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.A 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 1.125 Note.B 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 2
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 2
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.0625 Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.0625 Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.Ad 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.0625 Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Fd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 3 
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.0625 Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.D 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Dd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Fd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 0
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.1825 Note.Ad 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Dd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.Dd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Fd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.Ad 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.Dd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.375 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 5
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.75 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.B 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.F 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.Gd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.Dd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.D 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.E 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.625 Note.Fd 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.5 Note.A 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 4
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.125 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.25 Note.G 3
        MainTheme <- MainTheme @ Wave.MakeNote (Wave.Sine) 0.825 Note.C 4

        MainTheme


    let Thunder() : float list =
        let mutable Thunderstruck = Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.G 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.A 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Gd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.A 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Gd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.A 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Gd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.A 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Gd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Fd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.E 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.Dd 5
        Thunderstruck <- Thunderstruck @ Wave.MakeNote(Wave.Sine) 0.125 Note.B 4

        Thunderstruck

    let Through() : float list = 
        let mutable ThroughFireAndFlames = Wave.MakeNote (Wave.Sine) 0.1 Note.DEBUG 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Ad 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Ad 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Ad 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Ad 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Ad 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3


        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 3



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Ad 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Ad 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.2 Note.Ad 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.2 Note.C 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Ad 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4






        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        //

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        
        
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        
        
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.4 Note.G 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        //

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        
        
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4



        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        
        
        
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.C 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.D 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Dd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.F 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Gd 4
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 4

        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Fd 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Fd 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Fd 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Fd 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Fd 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.Fd 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.1 Note.G 5
        ThroughFireAndFlames <- ThroughFireAndFlames @ Wave.MakeNote (Wave.Sine) 0.3 Note.Fd 5


        ThroughFireAndFlames
