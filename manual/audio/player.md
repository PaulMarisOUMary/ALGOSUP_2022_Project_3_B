# Module Player

## Player
```fsharp
module Player
```
Attributes:
`none`

Methods:
- [Play](#play)

## Play
---
```fsharp
method Play (loop:boolean) (wave: float list)
```
Play the sound wave live.
:warning: `arm64` architecture is not compatible yet.

#### Example Usage:
```fsharp
wave |> Player.Play true
```
The wave will be played live.

#### Parameters:
`loop` : mandatory
Whether or not to loop the sound.
This parameter set to true, it loop the generated sound.

<ins>Type</ins> : [boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean?view=net-6.0)

`wave` : mandatory
The wave to play.
More information about the wave can be found in the [Wave](/ALGOSUP_2022_PROJECT_B/audio/wave) manual.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)> | ([wave](/ALGOSUP_2022_Project_3_B/audio/wave))
