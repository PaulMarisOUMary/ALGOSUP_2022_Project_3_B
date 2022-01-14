namespace Synth

module Note =

    type Note =
        | A
        | B
        | C
        | D
        | E
        | F
        | G
        | DEBUG

    let GetFrequency (note:Note) (octave:int) =
        let frequencyBeforeOctave = 
            match note with
            | A -> 440.
            | B -> 493.88
            | C -> 261.63
            | D -> 293.66
            | E -> 329.63
            | F -> 349.23
            | G -> 392.
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
