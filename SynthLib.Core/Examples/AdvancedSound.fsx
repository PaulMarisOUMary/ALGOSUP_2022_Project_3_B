namespace SynthLib.Core.Songs

module AdvancedSound =

    open SynthLib
    open SynthLib.Audio

    // Create note
    let note lenght note octave =
        Wave.MakeNote Wave.Sine lenght note octave
        |> Envelope.apply 0.1 0.06 0.1 0.8          // apply smooth envelope
        |> Filter.Echo 0.4                          // apply echo filter

    // Macro methods
    let fullNote = note 1.
    let halfNote = note 0.5
    let quarterNote = note 0.25
    let eightNote = note 0.125

    // The sound
    let MoonSong : float list =
        [
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
        ]