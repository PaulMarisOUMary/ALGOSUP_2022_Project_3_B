
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

        writer.Write("fmt"B) //fmt header
        writer.Write(16) //format size
        if audioFormat.IsNone then writer.Write(1s) else writer.Write(audioFormat.Value) //Default value is 1 for uncompressed data
        if numChannels.IsNone then writer.Write(1s) else writer.Write(numChannels.Value) //Default value is 1 for mono, 2 for stereo etc
        if sampleRate.IsNone then writer.Write(8000) else writer.Write(sampleRate.Value) //Default value is 8000 for average
        
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

    let write stream (data:byte[]) =
        use writer = new BinaryWriter(stream)
        // RIFF
        writer.Write("RIFF"B)
        let size = 36 + data.Length in writer.Write(size)
        writer.Write("WAVE"B)
        // fmt
        writer.Write("fmt "B)
        let headerSize = 16 in writer.Write(headerSize)
        let pcmFormat = 1s in writer.Write(pcmFormat)
        let mono = 1s in writer.Write(mono)
        let sampleRate = 8000 in writer.Write(sampleRate)
        let byteRate = sampleRate in writer.Write(byteRate)
        let blockAlign = 1s in writer.Write(blockAlign)
        let bitsPerSample = 8s in writer.Write(bitsPerSample)
        // data
        writer.Write("data"B)
        writer.Write(data.Length)
        writer.Write(data)
    
    
