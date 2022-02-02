# Module Envelope

## Envelope
```fsharp
module Envelope
```
Attributes:
`none`

Methods:
- [apply](#apply)

## apply
---
```fsharp
method apply (attackTime:float) (decayTime:float) (releaseTime:float) (sustainAmplitude:float) (wave: float list)
```
Return a Wave with an envelope applied to it.

#### Example Usage:
```fsharp
Wave.MakeNote Wave.Sine 1. Note.A 4
    |> Envelope.apply 0.1 0.06 0.1 0.8
```

#### Parameters:

`attackTime` : mandatory
The time in seconds for the attack.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`decayTime` : mandatory
The time in seconds for the decay.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`releaseTime` : mandatory
The time in seconds for the release.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`sustainAmplitude` : mandatory
The amplitude of the sustain.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`wave` : mandatory
The wave to apply the envelope to.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a wave.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/audio/wave))