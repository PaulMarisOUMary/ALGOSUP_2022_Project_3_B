# Introduction

This is the documentation for the SynthLib library.

SynthLib works with F# and hab been tested with `F# Interactive version 12.0.0.0 for F# 6.0`.

## Prerequisites

Please install the latest version of `.NET` and `FSharp` on your machine.

###### Quick links :
- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- [FSharp](https://fsharp.org/)

## Installing

<img src="https://www.nuget.org/Content/gallery/img/logo-og-600x600.png" width="30px" style="float:left">
#### NuGet

##### - Install SynthLib with IDE:

In your project install-Package SynthLib via the NuGet Package Manager.

Then add the following line to your code:
```fsharp
open SynthLib
// open SynthLib.Audio | or | .YourTargetModule
```
Then you can use the library.

##### - Install SynthLib with command line:

```bash
# Using dotnet CLI
$ dotnet add package SynthLib

```
*or*
```bash
# Using NuGet CLI
$ Install-Package SynthLib
```

###### Quick link:
- [SynthLib on NuGet](https://www.nuget.org/packages/SynthLib/)

#### Developement version

If you want to contribute or use the latest version of SynthLib, you can use it by downloading the source code from [GitHub](https://PaulMarisOUMary/SynthLib/tree/master/src) and include it in your project.

Then in your `.fsproj` file, add the following lines:
```html
<Project Sdk="Microsoft.NET.Sdk">

    ... other references ...

  <ItemGroup>
    <ProjectReference Include="..\SynthLib\SynthLib.fsproj" />
  </ItemGroup>

    ... other references ...

</Project>
```

### Next step:
[Quickstart](/ALGOSUP_2022_Project_3_B/quickstart)