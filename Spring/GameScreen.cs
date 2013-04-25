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


        //Constructor
        public GameScreen()
        {

        }

        //Update
        public void Update(MouseState mouse, KeyboardState keyboard, GamePadState gamePadState)
        {

        }

        //Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.GraphicsDevice.Clear(Color.Yellow);
        }


    }
}
