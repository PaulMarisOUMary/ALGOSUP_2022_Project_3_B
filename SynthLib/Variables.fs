namespace SynthLib

module Variables =
    
    let DEBUG = false

    let mutable sampleRate = if DEBUG then 40 else 44100
