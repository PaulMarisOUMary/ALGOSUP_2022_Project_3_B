namespace SynthLib.Core.Examples

module EncodeSoundToWav =

    open SynthLib.Audio
    open SynthLib.Compression

    let Example =
        // Create the sound
        let ourWave = Wave.MakeNote Wave.Sine 1. Note.A 4

        // Prepare to encode
        let byteArray = ourWave |> Wav.ToByteArray

        // Encode to .wav
        Wav.EncodeWav
            @"../../../../output.wav"   // Path
            byteArray    