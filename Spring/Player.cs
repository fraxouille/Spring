using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Spring
{
    class Player
    {
        //Properties
        private int x = 0, y = 0;
        private int width, height;
        private Texture2D texture;

        //Constructor
        public Player()
        {
            texture = Res.playerTexture;
            width = texture.Width;
            height = texture.Height;
        }
        
        //Update
        public void Update(MouseState mouse)
        {

        }

        public void Update(KeyboardState keyboard)
        {
            if (keyboard.IsKeyDown(Keys.Up)) y--;
            if (keyboard.IsKeyDown(Keys.Down)) y++;
            if (keyboard.IsKeyDown(Keys.Left)) x--;
            if (keyboard.IsKeyDown(Keys.Right)) x++;
        }

        public void Update(GamePadState gamePadState)
        {

        }

        //Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(x, y, width, height), Color.White);
        }

    }
}
