using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spring
{
    //Sub-class of Ground.cs
    class Layer
    {
        public int width, height;
        public int[,] layer;

        public Layer(int width, int height)
        {
            this.width = width;
            this.height = height;
            layer = new int[width,height];
        }

    }
}
