namespace SynthLib

module Variables =

    let DEBUG = false

    let mutable sampleRate = if DEBUG then 4000 else 44100
