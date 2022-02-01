namespace SynthLib.Audio


module Envelope =

    open System
    open SynthLib.Variables

    let apply (attackTime : float) (decayTime : float) (releaseTime : float) (sustainAmplitude : float) (wave : list<float>) =  //ADSR for Attack Decay Sustain and Release
        [

        let attackAmplitude = 1.

        //calculte times in number of samples
        let attackTimeSample = int(attackTime * (float wave.Length))
        let decayTimeSample = int(decayTime * (float wave.Length))
        let releaseTimeSample =  int(releaseTime * (float wave.Length))

        for index in 0..wave.Length-1 do
            //Attack time
            if index < attackTimeSample then 
                yield ((float index)/(float attackTimeSample)) * wave.[index]
            //Decay time
            elif index > attackTimeSample && index < ( attackTimeSample + decayTimeSample ) then
                yield ((float ((float index - float attackTimeSample)/float decayTimeSample)) * (sustainAmplitude-attackAmplitude) + attackAmplitude) * wave.[index]
            //Sustain time
            elif index > (attackTimeSample + decayTimeSample) && index < (wave.Length - releaseTimeSample) then
                yield sustainAmplitude * wave.[index]
            //release time
            elif index > (wave.Length - releaseTimeSample) then
                yield (((float wave.Length-1.)-(float index))/(float releaseTimeSample)) * (float wave.[index]*sustainAmplitude)
        
        ]
        