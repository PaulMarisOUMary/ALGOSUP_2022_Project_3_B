namespace SynthLib.Audio

module Player =

    open SFML.Audio
    open SynthLib.Compression.Wav
    
    let Play (wave : float list ) loop = 
        let buffer = new SoundBuffer ( wave |> ToByteArray ) 
        let player = new SFML.Audio.Sound(buffer)
        player.Loop <- loop
        player.Play()
        System.Console.Read()
        