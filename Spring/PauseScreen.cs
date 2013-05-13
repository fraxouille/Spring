using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Spring
{
    // Pause Screen
    class PauseScreen
    {
        //Properties


        //Constructor
        public PauseScreen()
        {

        }

        //Update
        public void Update(MouseState mouse, KeyboardState keyboard, GamePadState gamePadState)
        {

        }

        //Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.GraphicsDevice.Clear(Color.Tomato);
        }
    }
}
