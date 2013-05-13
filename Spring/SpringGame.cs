#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace Spring
{
    //Main class
    public enum GameState
    {
        Menu, Game, Pause
    };

    public class SpringGame : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //*******GameState*******//
        public static GameState gameState;
        
        private MenuScreen menuScreen;
        private GameScreen gameScreen;
        private PauseScreen pauseScreen;

        private MouseState mouseState;
        private KeyboardState keyboardState;
        private GamePadState gamePadState;


        public SpringGame() : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Res.LoadContent(Content);

            gameState = GameState.Game;
            menuScreen = new MenuScreen();
            gameScreen = new GameScreen();
            pauseScreen = new PauseScreen();
        }

        protected override void UnloadContent()
        {

        }

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                //Exit();

            mouseState = Mouse.GetState();
            keyboardState = Keyboard.GetState();
            gamePadState = GamePad.GetState(PlayerIndex.One);

            switch (gameState)
            {
                case GameState.Menu:
                    {
                        menuScreen.Update(mouseState, keyboardState, gamePadState);
                        break;
                    }
                case GameState.Game:
                    {
                        gameScreen.Update(mouseState, keyboardState, gamePadState);
                        break;
                    }
                case GameState.Pause:
                    {
                        pauseScreen.Update(mouseState, keyboardState, gamePadState);
                        break;
                    }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            GraphicsDevice.Clear(Color.CornflowerBlue);


            //spriteBatch.Draw(Ressources.playerTexture, new Rectangle(10, 10, 100, 100), Color.White);

            switch (gameState)
            {
                case GameState.Menu:
                    {
                        menuScreen.Draw(spriteBatch);
                        break;
                    }
                case GameState.Game:
                    {
                        gameScreen.Draw(spriteBatch);
                        break;
                    }
                case GameState.Pause:
                    {
                        pauseScreen.Draw(spriteBatch);
                        break;
                    }
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
