# Introduction

This is the documentation for the SynthLib library.

## Prerequisites

SynthLib works with F# and hab been tested with `F# Interactive version 12.0.0.0 for F# 6.0`.

###### Quick links :
- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- [FSharp](https://fsharp.org/)

## Installing

This library is not published yet on NuGet Package Manager.

You can use it by downloading the source code from [GitHub](https://PaulMarisOUMary/SynthLib/tree/master/src) and include it in your project.

Then in your `.fsproj` file, add the following lines:
```html
<Project Sdk="Microsoft.NET.Sdk">

    ...

  <ItemGroup>
    <ProjectReference Include="..\SynthLib\SynthLib.fsproj" />
  </ItemGroup>

    ...

</Project>
```