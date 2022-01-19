namespace Synth

module Variables =
    
    let DEBUG = false

    let mutable sampleRate = if DEBUG then 40 else 8000

