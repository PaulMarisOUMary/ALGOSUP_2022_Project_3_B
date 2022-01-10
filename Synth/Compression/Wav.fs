
module Wave
    
    open System.IO

    
  

    let private EncoderWav (path:string)
        (data:byte[])
        (audioFormat:option<int16>)
        (numChannels:option<int16>)
        (sampleRate:option<int16>)
        (blockAlign:option<int16>) 
        (bitsPerSample:option<int16>) =
        
        let stream = File.Create(path)
        use writer = new BinaryWriter(stream)

        writer.Write("RIFF"B) //RIFF header
        writer.Write(36 + data.Length) //Total File Size - 8
        writer.Write("WAVE"B) //WAVE header

        writer.Write("fmt "B) //fmt header
        writer.Write(16) //format size
        if audioFormat.IsNone then writer.Write(1s) else writer.Write(audioFormat.Value) //Default value is 1 for uncompressed data
        if numChannels.IsNone then writer.Write(1s) else writer.Write(numChannels.Value) //Default value is 1 for mono, 2 for stereo etc
        if sampleRate.IsNone then writer.Write(8000) else writer.Write(int sampleRate.Value) //Default value is 8000 for average
        
        let (byteRate:int) = int ((if sampleRate.IsNone then  8000s else sampleRate.Value )
            * (if numChannels.IsNone then 1s else numChannels.Value) 
            * (if bitsPerSample.IsNone then 1s else bitsPerSample.Value))
        writer.Write(byteRate) //ByteRate = sampleRate * numchannels * ByteperSample
   
        if blockAlign.IsNone then writer.Write(1s) else writer.Write(blockAlign.Value) //Default value is 1 for uncompressed data
        if bitsPerSample.IsNone then writer.Write(8s) else writer.Write(bitsPerSample.Value) //Default value is 1 for uncompressed data


        writer.Write("data"B)
        writer.Write(data.Length)
        writer.Write(data)

    let EncodetoWav path data parameters = 
           EncoderWav path data None None None None None

    let DecodeWav (path:string) = 3