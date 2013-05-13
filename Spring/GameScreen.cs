using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Spring
{
    // Screen of the main game
    class GameScreen
    {
        //Properties
        private Player player;
        private Ground ground;
        string mapFileName = "Map";

        //Constructor
        public GameScreen()
        {
            player = new Player();
            ground = new Ground(mapFileName);
        }

        //Update
        //Only calls sub-methods with right inputs
        public void Update(MouseState mouse, KeyboardState keyboard, GamePadState gamePadState)
        {
            switch (Settings.inputType)
            {
                case (Settings.InputType.Keyboard):
                    {
                        player.Update(keyboard);
                        ground.Update(keyboard);
                        break;
                    }
                case (Settings.InputType.Pad):
                    {
                        player.Update(gamePadState);
                        ground.Update(gamePadState);
                        break;
                    }
                case (Settings.InputType.Mouse):
                    {
                        player.Update(mouse);
                        ground.Update(mouse);
                        break;
                    }
            }
        }

        //Draw
        //Only calls sub-methods
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.GraphicsDevice.Clear(Color.Yellow);
            ground.DrawBackground(spriteBatch);
            player.Draw(spriteBatch);
            ground.DrawForeground(spriteBatch);
        }


    }
}
