namespace SynthLib.Core.Examples


module VisualizeSound =

    open SynthLib.Audio
    open SynthLib.Visualization

    let Example =
        // Create the sound
        let ourWave = Wave.MakeNote Wave.Sine 1. Note.DEBUG 4 // Note.DEBUG to visualize the WaveForm

        // Visualize sound
        Chart.Chart
            [ourWave]       // Sound to visualize
            1200            // xSize
            250             // ySize