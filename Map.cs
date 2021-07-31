using System;
using System.Collections.Generic;
using System.Text;

namespace _4Elements
{
    class Map
    {
        public readonly int width;
        public readonly int height;
        private MapTile[] tiles;
        // private Elemental[] elementals;
        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
