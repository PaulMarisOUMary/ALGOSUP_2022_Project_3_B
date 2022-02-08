namespace SynthLib.Core.Examples

module CreateSound =

    open SynthLib.Audio

    let Example =
        let ourWave = // Create the sound
            Wave.MakeNote
                Wave.Sine   // WaveForm | see : paulmarisoumary.github.io/ALGOSUP_2022_Project_3_B/_posts/audio/wave
                1.          // Duration 0 -> +∞
                Note.A      // Note     | see : paulmarisoumary.github.io/ALGOSUP_2022_Project_3_B/_posts/audio/note
                4           // Octave   0 -> 8

        ourWave