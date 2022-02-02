namespace SynthLib.Audio

module Player =

    open SFML.Audio
    open SynthLib.Variables
    
    let Play loop (wave : float list ) = 
        let buffer = new SoundBuffer ( ( wave |> List.map (fun (x:float) -> int16 (x * 32767.)) |> List.toArray ),uint32 1 ,uint32 sampleRate ) 
        let player = new SFML.Audio.Sound(buffer)
        player.Loop <- loop
        player.Play()
        System.Console.Read()
        