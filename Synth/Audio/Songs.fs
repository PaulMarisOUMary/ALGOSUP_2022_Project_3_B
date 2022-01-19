namespace Synth
open Synth
open Variables

module Songs =

    let MoonSong () : float list =
        let mutable MoonTune = Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 1. Note.E 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 1. Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.E 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 1. Note.C 4
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 1. Note.DEBUG 4

        MoonTune


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
        Wave.MakeNote (Wave.Sine) 3. Note.A 4



