# Module Filter

## Filter
```fsharp
module Filter
```
Attributes:
`none`

Methods:
- [Amplitude](#amplitude)
- [Overdriven](#overdriven)
- [Echo](#echo)
- [Flange](#flange)
- [Reverb](#reverb)
- [Low Pass](#low-pass)
- [High Pass](#high-pass)
- [LfoAmp](#lfoamp)
- [LfoFreq](#lfofreq)

## Amplitude
---
```fsharp
method Amplitude (amplitudeChange : float) (wave : List<float>)
```

#### Example Usage:
```fsharp
let wave = Wave.MakeNote (Wave.Square) 1. Note.A 4 
            |> Amplitude 0.5
```

#### Parameters:

`amplitudeChange` : mandatory
The amplitude value you want to apply to the wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`wave` : mandatory
The wave you want to modify.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a new wave with a modified Amplitude/Intensity.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))

## Overdriven
---
```fsharp
method Overdriven (amplitude : float) (wave : List<float>)
```

#### Example Usage:
```fsharp
let wave = Wave.MakeNote (Wave.Square) 1. Note.A 4 
            |> Overdriven 0.8
```

#### Parameters:

`amplitude` : mandatory
The overdriven value you want to apply to the wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`wave` : mandatory
The wave you want to modify.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a new wave with a overdrive.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))

## Echo
---
```fsharp
method Echo (duration : float) (wave : List<float>)
```

#### Example Usage:
```fsharp
let wave = Wave.MakeNote (Wave.Square) 1. Note.A 4 
            |> Echo 0.4
```

#### Parameters:

`duration` : mandatory
The duration of the wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`wave` : mandatory
The wave you want to modify.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a modified wave with a echo effect applied to it.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))

## Flange
---
```fsharp
method Flange (maxTimeDelay : float) (speed : float) (wave : List<float>)
```
Return a modified wave with a flange effect applied to it.

#### Example Usage:
```fsharp
let wave = Wave.MakeNote (Wave.Square) 1. Note.A 4 
            |> Flange 2. 0.8
```

#### Parameters:

`maxTimeDelay` : mandatory
The delay of the flange effect.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`speed` : mandatory
The speed of the flange effect.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`wave` : mandatory
The wave you want to modify.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a modified wave with a flange effect applied to it.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))

## Reverb
---
```fsharp
method Reverb (times: int) (firstDuration : float) (wave : List<float>)
```

#### Example Usage:
```fsharp
let wave = Wave.MakeNote (Wave.Square) 1. Note.A 4 
            |> Reverb 2.5 0.5
```

#### Parameters:

`times` : mandatory
The time of the reverb effect.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`firstDuration` : mandatory
The duration of the echo in the flange effect.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`wave` : mandatory
The wave you want to modify.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a modified wave with a reverb effect applied to it.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))

## Low Pass
---
```fsharp
method LowPass cutoffFreq (data:List<float>)
```

#### Example Usage:
```fsharp
let wave = Wave.MakeNote (Wave.Square) 1. Note.A 4 
            |> LowPass 500.
```

#### Parameters:

`cutoffFreq` : mandatory
The cutoff frequency you want to apply to the wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)


`data` : mandatory
The wave you want to modify.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a modified wave with a LowPass effect applied to it.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))


## High Pass
---
```fsharp
method HighPass cutoffFreq (data : List<float>)
```

#### Example Usage:
```fsharp
let wave = Wave.MakeNote (Wave.Square) 1. Note.A 4 
            |> HighPass 500.
```

#### Parameters:

`cutoffFreq` : mandatory
The cutoff frequency you want to apply to the wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)


`data` : mandatory
The wave you want to modify.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a modified wave with a HighPass effect applied to it.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))


## LfoAmp
---
```fsharp
method LfoAmp (rate : float)(depth : float)(typewave)(wave : List<float>)
```

#### Example Usage:
```fsharp
let wave = Wave.MakeNote (Wave.Square) 1. Note.A 4 
            |> LfoAmp 0.4 0.7 Wave.Sinus
```

#### Parameters:

`rate` : mandatory
The low frequency of the LFO (0 to 20 Hz).

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`depth` : mandatory
The Amplitude of the LFO wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`typewave` : mandatory
The type of the wave using by the LFO.

<ins>Type</ins> : func([float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)*[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)->[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0))


`wave` : mandatory
The wave you want to modify.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a modified wave with a LFO applied to it.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))

## LfoFreq
---
```fsharp
method LfoFreq (rate: float)(depth: float)(typewave)(wave : List<float>)
```

#### Example Usage:
```fsharp
let wave = Wave.MakeNote (Wave.Square) 1. Note.A 4 
            |> LfoFreq 0.4 0.7 Wave.Sinus
```

#### Parameters:

`rate` : mandatory
The low frequency of the LFO (0 to 20 Hz).

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`depth` : mandatory
The Amplitude of the LFO wave.

<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

`typewave` : mandatory
The type of the wave using by the LFO.

<ins>Type</ins> : func([float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)*[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)->[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0))


`wave` : mandatory
The wave you want to modify.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

#### Returns:
Return a modified wave with a LFO applied to a low pass filter.
<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/_posts/audio/wave))



