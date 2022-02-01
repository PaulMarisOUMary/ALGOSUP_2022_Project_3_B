# Module Wave

## Wave
```fsharp
module Wave
```
Attributes:
`none`

Methods:
- [Sine](#sine)
- [Square](#square)
- [Triangle](#triangle)
- [Sawtooth](#sawtooth)
- [Identity](#identity)

- [MakeNote](#makenote)
- [Combine](#combine)

## Sine
---
```fsharp
method Sine (frequency:float) (duration:float)
```
Return a point-sampled sine wave.

#### Example Usage:
```fsharp
let wave = Wave.Sine 440. 1.
```

#### Parameters:

`frequency` : mandatory
The frequency of the sine wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`duration` : mandatory
The duration of the wave in seconds.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)