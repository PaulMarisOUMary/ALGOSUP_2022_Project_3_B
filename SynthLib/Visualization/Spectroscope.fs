namespace SynthLib.Chart

open SynthLib.Chart.Visualization
module Spectroscope =
    let SpecVisu song =
        let Waves : List<List<float>> = [
            [for x in song do
                if x <= 0. then
                    yield x * -1.
                else
                    yield x];
            [for y in song do
                if y >= 0. then
                    yield y * -1.
                else
                    yield y]
        ]
        SynthLib.Chart.Visualization.ChartBar Waves 1200 500
    