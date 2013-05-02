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
            player.Update(mouse, keyboard, gamePadState);
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
