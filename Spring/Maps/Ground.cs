using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Spring
{
    //Background class
    class Ground
    {
        //Properties
        public int id, height, width, layersNumber;
        public string name, spriteSheet;
        public Layer[] layers;

        //Constructor
        public Ground()
        {

        }

        public Ground(String mapFileName)
        {
            Ground g = XMLParser.XMLReader(mapFileName);
            this.id = g.id;
            this.name = g.name;
            this.height = g.height;
            this.width = g.width;
            this.layers = g.layers;
        }

        //Update
        public void Update(MouseState mouse)
        {

        }

        public void Update(KeyboardState keyboard)
        {

        }

        public void Update(GamePadState gamePadState)
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
