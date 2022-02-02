# Quickstart

This page gives a brief introduction to the library. It assumes that the library is installed, if not, please refer to the [introduction](/ALGOSUP_2022_Project_3_B/introduction) section.

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

More details on Manual : module [Wave](/ALGOSUP_2022_Project_3_B/audio/wave).

### Save sound to disk

To save a sound to disk in `.wav` format, we need to convert the Wave format in a byte format with the `Wav.ToByteArray` method.

```fsharp
let byteArray = ourWave |> Wav.ToByteArray
```

Once we have the byte array, we can save it to disk with the `Wav.Encode` method.

```fsharp
// using ourWave, see the "Create our first sound" section

Wav.EncodeWav
    @"../../../../output.wav"   // Path
    byteArray                   // ByteArray
```

Then you can play the sound localy with you favourite software.

More details on Manual : module [Wav](/ALGOSUP_2022_Project_3_B/compression/wav).

### Play sound live

If you want to play the sound live, you can use the `Player.Play` method.

```fsharp
// using ourWave, see the "Create our first sound" section

ourWave |> Player.Play true
```

More details on Manual : module [Player](/ALGOSUP_2022_Project_3_B/audio/player).