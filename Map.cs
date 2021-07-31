using System;
using System.Collections.Generic;
using System.Text;

namespace _4Elements
{
    class Map
    {
        public readonly int width;
        public readonly int height;
        private readonly MapUpdater updater;
        public MapTile[,] tiles { get; set; }
        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;
            updater = new MapUpdater();
        }
        public void UpdateSelf()
        {
            updater.UpdateMap(this);
        }
    }
}
