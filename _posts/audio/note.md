# Module Note

## Note
```fsharp
module Note
```
Attributes:
`none`

Methods:
- [GetFrequency](#getfrequency)

Types:
- [Note](#note)

## GetFrequency
---
```fsharp
method GetFrequency (note:Note) (octave: int)
```
Return the frequency in function of a note and octave.
This method is mainly use in the [Wave.MakeNote](/ALGOSUP_2022_Project_3_B/_posts/audio/wave#makenote) method.

#### Example Usage:
```fsharp
let calculateFrequency = Note.GetFrequency Note.A 4
```
Returns a frequency of Note.A octave 4.

#### Parameters:
`note` : mandatory


<ins>Type</ins> : [Note](#note)

`octave` : mandatory
The octave, between [0 and 8].

<ins>Type</ins> : [int](https://docs.microsoft.com/en-us/dotnet/api/system.int32?view=net-6.0)

#### Returns :
Returns the frequency.
<ins>Type</ins> : [float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)

## Note
---
```fsharp
type Note
```
The note type. Mainly use in the [GetFrequency](#getfrequency) method and while creating sounds. This type is in agreement with the music range.

#### Values:
```fsharp
- A
- As
- B
- C
- Cs
- D
- Ds
- E
- F
- Fs
- G
- Gs
- LFO
- REST // avoid computation of the wave returns always 0
- DEBUG // used to debug and visualize waves with Charts
```