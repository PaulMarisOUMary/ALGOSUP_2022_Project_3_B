namespace Synth

open XPlot.Plotly
open XPlot.GoogleCharts
open System
open Variables



module Visualization =

     let Chart datas xSize ySize =
     
        let Graph =
            datas 
            |> List.map ( fun l -> List.mapi (fun i x -> (float i / float sampleRate, x)) l)
            |> Chart.Combo
            |> Chart.WithSize (xSize, ySize)
        Chart.Show Graph

