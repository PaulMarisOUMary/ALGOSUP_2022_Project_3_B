namespace SynthLib

open System
open SynthLib.Variables

module Envelope =
    let apply (wave : list<float>)=  //ADSR for Attack Decay Sustain and Release
        [
        //Parameter to modify the effect
        let attackTime = 0.1
        let attackAmplitude = 1.
        let decayTime = 0.01
        let releaseTime = 0.1
        let sustainAmplitude = 0.8
        let noteTime = (wave.Length/sampleRate)

        let mutable output = 0.

        let attackTimeSample = int(attackTime * (float wave.Length))
        let decayTimeSample = int(decayTime * (float wave.Length))
        let releaseTimeSample =  int(releaseTime * (float wave.Length))

        for index in 0..wave.Length-1 do
            //Attack time
            if index < (int (attackTime * (float wave.Length))) then 
                output <- ((float index)/(float attackTimeSample)) * wave.[index]
            //Decay time
            elif index > attackTimeSample && index < (attackTimeSample+decayTimeSample) then
                output <- ((float ((float index - float attackTimeSample)/float decayTimeSample)) * (sustainAmplitude-attackAmplitude) + attackAmplitude) * wave[index]
            //Sustain time
            elif index > (attackTimeSample+decayTimeSample) && index < (wave.Length-releaseTimeSample) then
                output <- sustainAmplitude * wave.[index]
            //release time
            elif index > (wave.Length-releaseTimeSample) then
                output <- (((float wave.Length-1.)-(float index))/(float releaseTimeSample)) * (float wave.[index]*sustainAmplitude)
            
            yield output

        ]
        