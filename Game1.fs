namespace Test

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Input

type Game1() as this =
    inherit Game()

    let graphics = new GraphicsDeviceManager(this)
    let mutable spriteBatch: SpriteBatch = null

    do
        this.Content.RootDirectory <- "Content"
        this.IsMouseVisible <- true

    override _.Initialize() =
        // TODO: Add your initialization logic here

        base.Initialize()

    override _.LoadContent() =
        spriteBatch <- new SpriteBatch(this.GraphicsDevice)

        // TODO: use this.Content to load your game content here

    override _.Update(gameTime: GameTime) =
        let kstate = Keyboard.GetState()
        if kstate.IsKeyDown Keys.Escape then
            this.Exit()

        // TODO: Add your update logic here

        base.Update gameTime

    override _.Draw(gameTime: GameTime) =
        this.GraphicsDevice.Clear Color.CornflowerBlue

        spriteBatch.Begin()
        // TODO: Add your drawing code here
        spriteBatch.End()

        base.Draw gameTime