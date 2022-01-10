namespace Synth

open XPlot.Plotly
open XPlot.GoogleCharts
open System

module Visualization =
     let Chart datas =
        let Graph =
            datas 
            |> Chart.Combo
            |> Chart.WithSize (1200, 250)
        Chart.Show Graph
