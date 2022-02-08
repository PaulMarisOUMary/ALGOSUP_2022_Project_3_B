namespace SynthLib.Core.Examples

module ApplyFilterToSound =

    open SynthLib.Audio

    let Example =
        // Create the sound
        let ourWave = Wave.MakeNote Wave.Sine 1. Note.A 4

        // Apply Filter
        let filterSound =
            ourWave |>
                // You can apply any filter
                Filter.Flange // more infos about Flange Fimter on : paulmarisoumary.github.io/ALGOSUP_2022_Project_3_B/_posts/audio/filter
                    0.015   // maxTimeDelay
                    1.      // Speed

        filterSound