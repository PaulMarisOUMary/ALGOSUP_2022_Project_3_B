namespace SynthLib.Core.Examples

module ChordTwoSound =

    open SynthLib.Audio

    let Example =
        // Create the sound
        let ourWave = Wave.MakeNote Wave.Sine 1. Note.A 4

        // Apply Filter
        let filterSound =
            ourWave |>
                // more infos: paulmarisoumary.github.io/ALGOSUP_2022_Project_3_B/_posts/audio/envelope#apply
                // What is an envelope? : en.wikipedia.org/wiki/Envelope_(music)
                Envelope.apply
                    0.1     // attackTime
                    0.06    // decayTime
                    0.1     // releaseTime
                    0.8     // sustainAmplitude

        filterSound