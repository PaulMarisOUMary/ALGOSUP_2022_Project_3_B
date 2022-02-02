# Module Wav

## Wav
```fsharp
module Wav
```
Attributes:
`none`

Methods:
- [EncodeWav](#encodewav)
- [DecodeWav](#decodewav)
- [ToByteArray](#tobytearray)

## EncodeWav
---
```fsharp
method EncodeWav (path:string) (data:byte[])
```

#### Example Usage:
```fsharp
Wav.EncodeWav @"../../../../YourWavName.wav" bitarray
```

#### Parameters:

`path` : mandatory

Define the path of your wav file.

<ins>Type</ins> : [string](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0)

`data` : mandatory
The byte data you want to encode.

<ins>Type</ins> : [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte?view=net-6.0)

#### Returns:
Write a .wav file at the specified path.

<ins>Type</ins> : [.wav](https://fr.wikipedia.org/wiki/Waveform_Audio_File_Format)