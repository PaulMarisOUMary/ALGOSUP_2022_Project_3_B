namespace SynthLib.Core.Examples

module PlaySoundLive =

    open SynthLib.Audio

    let Example =
        // Create the sound
        let ourWave = Wave.MakeNote Wave.Sine 1. Note.A 4

        // Play the sound live in a loop
        ourWave |>
            Player.Play
                true // true = loop