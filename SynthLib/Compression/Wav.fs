namespace SynthLib.Compression


module Wav = 

    open System.IO
    open System
    open SynthLib.Variables
    
    let EncodeWav (path:string) (data:byte[]) =
        
        let stream = File.Create(path)
        use writer = new BinaryWriter(stream)

        writer.Write("RIFF"B) //RIFF header
        writer.Write(36 + data.Length) //Total File Size - 8
        writer.Write("WAVE"B) //WAVE header

        writer.Write("fmt "B) //fmt header
        writer.Write(16) //format size
        writer.Write(1s) //Default value is 1 for uncompressed data
        writer.Write(1s) //Default value is 1 for mono, 2 for stereo etc
        writer.Write(sampleRate)         
        let (byteRate:int) =  sampleRate * 16
        writer.Write(byteRate) //ByteRate = sampleRate * ByteperSample
   
        writer.Write(1s) //Default value is 1 for uncompressed data
        writer.Write(16s) //Default value is 1 for uncompressed data


        writer.Write("data"B)
        writer.Write(data.Length)
        writer.Write(data)

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

    let ToByteArray (data:float list) =
        let bdata = data |> List.map (fun (x:float) -> System.BitConverter.GetBytes( (int16 ( x * 32767.))) )
        bdata |> List.reduce Array.append
