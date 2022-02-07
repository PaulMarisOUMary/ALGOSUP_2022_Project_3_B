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

## DecodeWav
---
```fsharp
method DecodeWav (path:string)
```

#### Example Usage:
```fsharp
Wav.DecodeWav @"../../../../YourWavName.wav"
```

#### Parameters:

`path` : mandatory

Define the path of your wav file.

<ins>Type</ins> : [string](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0)

#### Returns:
Decode a .wav file at the specified path and return a byte array.

<ins>Type</ins> : [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte?view=net-6.0)

## ToByteArray
---
```fsharp
method ToByteArray (data:float list)
```

#### Example Usage:
```fsharp
Wav.ToByteArray yourwavelist
```

#### Parameters:

`data` : mandatory
The list you want to convert.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Convert a list of float into a byte array.

<ins>Type</ins> : [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte?view=net-6.0)