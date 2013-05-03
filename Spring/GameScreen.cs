using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Spring
{
    class GameScreen
    {
        //Properties
        private Player player;
        private Ground ground;

        //Constructor
        public GameScreen()
        {
            player = new Player();
            ground = new Ground();
        }

        //Update
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
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.GraphicsDevice.Clear(Color.Yellow);
            ground.DrawBackground(spriteBatch);
            player.Draw(spriteBatch);
            ground.DrawForeground(spriteBatch);
        }


    }
}
