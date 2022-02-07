# Module Chart

## Chart
```fsharp
module Chart
```
Attributes:
`none`

Methods:
- [Chart](#chart)
- [ChartBar](#chartbar)

## Chart
---
```fsharp
method Chart datas xSize ySize
```

#### Example Usage:
```fsharp
let chart = Chart wave 1200 250
```

#### Parameters:

`data` : mandatory
The wave you want to display.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

`xSize` : mandatory
The size of the x-axis of your graph.

<ins>Type</ins> : [Px](https://fr.wikipedia.org/wiki/Pixel)

`ySize` : mandatory
The size of the y-axis of your graph.

<ins>Type</ins> : [Px](https://fr.wikipedia.org/wiki/Pixel)

#### Returns:
Return a line chart directly display on the browser.

## ChartBar
---
```fsharp
method ChartBar (datas: #value list list) (xSize: int) (ySize: int)
```

#### Example Usage:
```fsharp
let chart = ChartBar wave 1200 250
```

#### Parameters:

`datas` : mandatory
The value of the waves you want to display.

<ins>Type</ins> : [list](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)<[float](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0)>

`xSize` : mandatory
The size of the x-axis of your graph.

<ins>Type</ins> : [Px](https://fr.wikipedia.org/wiki/Pixel)

`ySize` : mandatory
The size of the y-axis of your graph.

<ins>Type</ins> : [Px](https://fr.wikipedia.org/wiki/Pixel)

#### Returns:
Return a bar chart directly display on the browser.


