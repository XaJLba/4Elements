using System;
using System.Collections.Generic;
using System.Text;

namespace _4Elements
{
    class MapUpdater
    {
        public void UpdateMap(Map map)
        {
            UpdateMapTiles(map.tiles);
        }

        private void UpdateMapTiles(MapTile[,] tiles)
        {
            UpdateWater(tiles);
            UpdateFire(tiles);
            UpdateNature(tiles);
        }

        private void UpdateWater(MapTile[,] tiles)
        {
            Console.WriteLine("updating water");
        }

        private void UpdateFire(MapTile[,] tiles)
        {
            Console.WriteLine("updating fire");
        }

        private void UpdateNature(MapTile[,] tiles)
        {
            Console.WriteLine("updating nature");
        }

        // terrain is not updated
    }
}
