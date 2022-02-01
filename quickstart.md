# Quickstart

This page gives a brief introduction to the library. It assumes that the library is installed, if not, please refer to the [installation](/installation) section.

---

## Minimal examples

Let's make and play sounds with the library.

### Create our first sound

To generate a sound, we need to create a `Wave`, 
which is created with the `Wave.MakeNote` method.
This method takes a <ins>WaveForm</ins>, a <ins>Duration</ins>, a <ins>Note</ins> and the <ins>Octave</ins> as parameters.

```fsharp
let ourWave = 
    Wave.MakeNote 
        Wave.Sine   // WaveForm
        1.          // Duration
        Note.A      // Note
        4           // Octave
```

More details on Manual : module Wave. <REPLACEME/>

### Save sound to disk

To save a sound to disk in `.wav` format, we need to convert the Wave format in a byte format with the `Wav.ToByteArray` method.

```fsharp
let byteArray = ourWave |> Wav.ToByteArray
```

Once we have the byte array, we can save it to disk with the `Wav.Encode` method.

```fsharp
Wav.EncodeWav
    @"../../../../output.wav"   // Path
    byteArray                   // ByteArray
```

Then you can play the sound localy with you favourite software.

More details on Manual : module Wav. <REPLACEME/>

### Play sound live

If you want to play the sound live, you can use the `NOT_IMPLEMENTED` method.

More details on Manual : module NOT_IMPLEMENTED. <REPLACEME/>