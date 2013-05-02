using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Spring
{
    class Ground
    {
        //Properties
        Layer[] layers;

        //Constructor
        public Ground()
        {
            layers = new Layer[5];
        }

        //Update
        public void Update(MouseState mouse, KeyboardState keyboard, GamePadState gamePadState)
        {

        }

        //Draw
        public void DrawBackground(SpriteBatch spriteBatch)
        {

        }

        public void DrawForeground(SpriteBatch spriteBatch)
        {

        }

    }
}
