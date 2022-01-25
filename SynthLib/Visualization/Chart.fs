namespace SynthLib.Chart

open SynthLib.Variables
open XPlot.Plotly
open XPlot.GoogleCharts
open System

module Visualization =

    let Chart datas xSize ySize =
     
        let Graph =
            datas
            |> List.map ( fun l -> List.mapi (fun i x -> (float i / float sampleRate, x)) l)
            |> Chart.Combo
            |> Chart.WithSize (xSize, ySize)
        Chart.Show Graph

    let ChartBar (datas: #value list list) (xSize: int) (ySize: int) =
        let Graph =
            datas
            |> List.map ( fun l -> List.mapi (fun i x -> (float i / float sampleRate, x)) l)
            |> XPlot.GoogleCharts.Chart.Bar
            |> XPlot.GoogleCharts.Chart.WithSize (xSize, ySize)
            |> XPlot.GoogleCharts.Chart.WithOptions (Options(orientation = "horizontal", colors=[|"#000000"|]))
        XPlot.GoogleCharts.Chart.Show Graph

