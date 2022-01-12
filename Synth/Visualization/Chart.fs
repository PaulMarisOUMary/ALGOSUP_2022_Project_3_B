namespace Synth

open XPlot.Plotly
open XPlot.GoogleCharts
open System

module Visualization =

     let Chart datas xSize ySize =
     
        let Graph =
            datas 
            |> List.map ( fun l -> List.mapi (fun i x -> (float i / 4000., x)) l)
            |> Chart.Combo
            |> Chart.WithSize (xSize, ySize)
        Chart.Show Graph

