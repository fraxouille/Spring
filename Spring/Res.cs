using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Spring
{
    //All ressources must be declared here
    static class Res
    {
        public static Texture2D playerTexture;
        public static Texture2D beachTexture;

        public static void LoadContent(ContentManager content)
        {
            playerTexture = content.Load<Texture2D>("gfx/hero_spritesheet");
            beachTexture = content.Load<Texture2D>("gfx/spritesheet_beach");
        }

    }
}
