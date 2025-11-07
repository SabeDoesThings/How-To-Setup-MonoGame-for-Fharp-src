open Test

[<EntryPoint>]
let main argv =
    use game = new Game1()
    game.Run()
    0