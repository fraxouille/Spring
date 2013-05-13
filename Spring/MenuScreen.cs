using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Spring
{
    //Screen of the main menu
    public class MenuScreen
    {
        //Properties


        // Constructor
        public MenuScreen()
        {

        }


        //Update
        public void Update(MouseState mouse, KeyboardState keyboard, GamePadState gamePadState)
        {

        }

        //Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.GraphicsDevice.Clear(Color.Green);
        }
    }
}
