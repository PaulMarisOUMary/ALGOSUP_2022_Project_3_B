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

Types:
`none`

## Sine
---
```fsharp
method Sine (frequency:float) (duration:float)
```
Return the value of a sine wave at a time t.

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

#### Returns:
Return the value of a sine wave at a time t.
<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

## Square
---
```fsharp
method Square (frequency:float) (duration:float)
```

Return the value of a square wave at a time t.

#### Example Usage:
```fsharp
let wave = Wave.Square 440. 1.
```

#### Parameters:

`frequency` : mandatory
The frequency of the square wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`duration` : mandatory
The duration of the wave in seconds.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

#### Returns:
Return the value of a square wave at a time t.
<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

## Triangle
---
```fsharp
method Triangle (frequency:float) (duration:float)
```

Return the value of a triangle wave at a time t.

#### Example Usage:
```fsharp
let wave = Wave.Triangle 440. 1.
```

#### Parameters:

`frequency` : mandatory
The frequency of the triangle wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`duration` : mandatory
The duration of the wave in seconds.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

#### Returns:
Return the value of a triangle wave at a time t.
<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

## Sawtooth
---
```fsharp
method Sawtooth (frequency:float) (duration:float)
```

Return the value of a sawtooth wave at a time t.

#### Example Usage:
```fsharp
let wave = Wave.Sawtooth 440. 1.
```

#### Parameters:

`frequency` : mandatory
The frequency of the sawtooth wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`duration` : mandatory
The duration of the wave in seconds.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

#### Returns:
Return the value of a sawtooth wave at a time t.
<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

## Identity
---
```fsharp
method Identity (frequency:float) (duration:float)
```
Return the value of a identity wave at a time t, in this case it's always `0.`. Combined with a [MakeNote](#makenote) it should represent silence/ an empty wave.

#### Example Usage:
```fsharp
let wave = Wave.Identity 0. 1.
```

#### Parameters:

`frequency` : mandatory
The frequency of the Identity wave. Whatever value it has, this parameter is ignored. It has been created to make the function callable combined with a [MakeNote](#makenote).

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`duration` : mandatory
The duration of the wave in seconds.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

#### Returns:
Return the value of a identity wave at a time t, in this case it's always `0.`.
<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0) (always `0.`)


## MakeNote
---
```fsharp
method MakeNote generator (duration:float) (note:Note) (octave:int)
```
Return a point-sampled note wave.

#### Example Usage:
```fsharp
let wave = Wave.MakeNote (Wave.Square) 1. Note.A 4
```

#### Parameters:

`generator` : mandatory
The type of the wave.

<ins>Type</ins> : func([float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)*[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)->[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0))

`duration` : mandatory
The duration of the wave in seconds.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`note` : mandatory
The note you want to play.

<ins>Type</ins> : Note

`octave` : mandatory
The octave of the note you want to play (0 to 8).

<ins>Type</ins> : [int](https://docs.microsoft.com/en-us/dotnet/api/system.int16?view=net-6.0)

#### Returns:
Return a wave.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))

## Combine
---
```fsharp
method Combine (args: list<list<float>>)
```
Return a chord of two or more waves.

#### Example Usage:
```fsharp
let wave = Wave.Combine([Wave.MakeNote Wave.Square 2. Note.E 4; Wave.MakeNote Wave.Square 2. Note.C 4])
```

#### Parameters:

`args` : mandatory
A list of all the different waves you want to combine.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a wave.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))