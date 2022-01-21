namespace SynthLib.Audio

module Note =

    type Note =
        | A
        | Ad
        | B
        | C
        | Cd
        | D
        | Dd
        | E
        | F
        | Fd
        | G
        | Gd
        | DEBUG

    let GetFrequency (note:Note) (octave:int) =
        let frequencyBeforeOctave = 
            match note with
            | C -> 523.25
            | Cd -> 554.37
            | D -> 587.33
            | Dd -> 622.25
            | E -> 659.26
            | F -> 698.46
            | Fd -> 739.99
            | G -> 783.99
            | Gd -> 830.61
            | A -> 880.00
            | Ad -> 932.33
            | B -> 987.77
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
