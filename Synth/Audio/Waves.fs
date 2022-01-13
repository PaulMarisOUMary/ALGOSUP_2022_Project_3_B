
namespace Synth

open System
open Variables

module Wave =

    let PI = Math.PI

    let (mod) x y=
        (x%y + y)%y

           
    let Sine frequency t = (Math.Sin(2. * PI * frequency * t))

    let Square frequency t = if (Math.Sin(2. * PI * frequency * t)) > 0. then 1. else - 1.

    let Triangle frequency t = (4. / frequency ) * Math.Abs(((t - frequency/4.) mod frequency) - frequency/2.) - 1.

    let Sawtooth frequency t = ((2. * t / frequency) mod 2.) - 1.

    let MakeNote generator (duration:float) note octave =
        let calculatedFrequency = Note.GetFrequency note octave in
        [
            for t in 0. .. 1. .. duration * (float sampleRate) do 
                yield  t / float sampleRate |> generator calculatedFrequency
        ]
       