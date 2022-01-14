namespace Synth

open System.IO
open System
open Variables

module Wav = 

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
        if parameters |> List.length = 0 then EncoderWav path data None None None None None else EncoderWav path data None None None None None 

    let DecodeWav (path:string) = 

        use reader = new BinaryReader(File.Open(path,FileMode.Open,FileAccess.Read))
        ignore(reader.ReadChars(4))
        let len = reader.ReadInt32()
        ignore(reader.ReadChars(8))
        let headersize = reader.ReadInt32()
        let format = reader.ReadInt16()
        let channel = reader.ReadInt16()
        sampleRate <- reader.ReadInt32()
        let bitRate = reader.ReadInt16()
        let blockAlign = reader.ReadInt16()
        let bitsPerSample = reader.ReadInt16()
        ignore(reader.ReadChars(4))
        let datalen = reader.ReadInt32()
        let mutable data = Array.zeroCreate<byte> datalen
        //reader.Read(data) // Compile error
        let wave = Array.zeroCreate<Int16> (datalen / 2)
        wave |> Array.mapi(fun i x -> BitConverter.ToInt16 (data,i) ) |> Array.map(fun x -> (float x) / 2.)
       
            



