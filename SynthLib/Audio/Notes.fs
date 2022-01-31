namespace SynthLib.Audio

module Note =

    type Note =
        | A
        | As
        | B
        | C
        | Cs
        | D
        | Ds
        | E
        | F
        | Fs
        | G
        | Gs
        | LFO
        | REST
        | DEBUG

    let GetFrequency (note:Note) (octave:int) =
        let frequencyBeforeOctave = 
            match note with
            | C -> 261.63 // DO
            | Cs -> 277.18
            | D -> 293.66 // RE
            | Ds -> 311.13
            | E -> 329.63 // MI
            | F -> 349.23 // FA
            | Fs -> 369.99
            | G -> 392.00 // SOL
            | Gs -> 415.30
            | A -> 440.00 // LA
            | As -> 466.16
            | B -> 493.88 // SI
            | LFO -> 4.
            | REST -> 0.
            | DEBUG -> 1. in

        match octave with
            | 0 ->  frequencyBeforeOctave / 16.
            | 1 ->  frequencyBeforeOctave / 8.
            | 2 ->  frequencyBeforeOctave / 4.
            | 3 ->  frequencyBeforeOctave / 2.
            | 4 ->  frequencyBeforeOctave 
            | 5 ->  frequencyBeforeOctave * 2.
            | 6 ->  frequencyBeforeOctave * 4.
            | 7 ->  frequencyBeforeOctave * 8.
            | 8 ->  frequencyBeforeOctave * 16.
            | _ -> raise (System.Exception($"Invalid Octave, expected 0< <8, got : {octave}"))
