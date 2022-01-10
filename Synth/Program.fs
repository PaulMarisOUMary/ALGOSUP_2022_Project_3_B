namespace Synth

open Synth

module Graph =
    open System
    open XPlot.Plotly
    open XPlot.GoogleCharts
    
    let a = 1.
    let h = 0.
    let b = 0.5
    let k = 0.
    let x = 0.
    
    let Sinus = [
        for x in 0. .. 0.01 .. 20. do yield (x.ToString() , (a * Math.Sin((x  - h) / b) + k))
        ]
    let Square = [
        for x in 0. .. 0.01 .. 20. do yield (x.ToString() , if (a * Math.Sin((x  - h) / b) + k) > 0. then 1. else -1.)
        ]
    let Triangle= [
        for x in 0. .. 0.01 .. 20. do yield (x.ToString() , (Math.Abs(x%4.-2.)-1.))
        ]
    let Tooth = [
        for x in 0. .. 0.01 .. 20. do yield (x.ToString() , ((x%2.)-1.))
        ]
    
    let Waves = [ Sinus ; Square; Triangle; Tooth]
    let Graph =
        Waves
        |> Chart.Combo
        |> Chart.WithSize (1200, 250)
    
    Chart.Show Graph

module Program =
    [<EntryPoint>]
    let main _  =
        printf "Hello world"
        let test = Sample()
        printfn $"test: {test.SampleMethod}"
        0
