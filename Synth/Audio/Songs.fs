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
        Wave.MakeNote(Wave.Sine) 1. Note.DEBUG 4


    let Doom () : float list =
        



