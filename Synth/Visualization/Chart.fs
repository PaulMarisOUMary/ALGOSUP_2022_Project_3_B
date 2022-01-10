namespace Synth

open XPlot.Plotly
open XPlot.GoogleCharts
open System

module Visualization =
     let Chart datas xSize ySize =
        let Graph =
            datas 
            |> Chart.Combo
            |> Chart.WithSize (xSize, ySize)
        Chart.Show Graph
