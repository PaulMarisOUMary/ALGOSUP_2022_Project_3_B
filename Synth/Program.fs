﻿namespace Synth

open Synth.Visualization
open Synth
open SFML

module Program =
    [<EntryPoint>]
    let main _  =

        let amplitude = 1.
        let frequency = 1.
        let from = 0.
        let step = 0.01
        let until = 20.
        let Wave = Waves(amplitude, frequency)
        
        let Waves : List<List<float * float>> = [
            Wave.Sinus from step until ;
            Wave.Square from step until ;
            Wave.Triangle from step until;
            Wave.Tooth from step until
        ]

        //Synth.Visualization.Chart Waves 1200 250
        use buffer = new Audio.SoundBuffer("../../../../Hello.wav")

        use sound = new Audio.Sound(buffer) 

        //sound.Loop <- true

        sound.Volume <- float32 100.

        sound.Play()

        ignore (System.Console.Read())

        0