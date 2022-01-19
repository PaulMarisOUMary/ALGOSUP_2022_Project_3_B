namespace Synth
open Synth
open Variables

module Songs =

    let mutable MoonTune = Wave.MakeNote (Wave.Sine) 0.5 Note.DEBUG 0
    
    for i in 0 .. 8 do
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.C i
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.D i 
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.E i
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.F i
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.G i
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.A i
        MoonTune <- MoonTune @ Wave.MakeNote (Wave.Sine) 0.5 Note.B i |> Filter.Amplitude 5.