
namespace Synth

open System

module Wave =

    let PI = Math.PI
    let samplerate = 4000

    let (mod) x y=
        (x%y + y)%y

           
    let Sine frequency t = (Math.Sin(2. * PI * frequency * t))

    let Square frequency t = if (Math.Sin(2. * PI * frequency * t)) > 0. then 1. else - 1.

    let Triangle frequency t = (4. / frequency ) * Math.Abs(((t - frequency/4.) mod frequency) - frequency/2.) - 1.

    let Sawtooth frequency t = ((2. * t / frequency) mod 2.) - 1.

    let MakeNote generator duration note octave =
        let calculatedFrequency = Note.GetFrequency note octave in
        [
            for t in 0 .. 1 .. duration * samplerate do 
                yield float t / float samplerate |> generator calculatedFrequency
        ]
       