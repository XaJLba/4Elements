using System;
using System.Collections.Generic;
using System.Text;

namespace _4Elements
{
    class MapRenderer
    {
        public void RenderMap(Map map)
        {
            foreach(MapTile tile in map.tiles)
            {
                RenderTile(tile);
            }
        }

        private void RenderTile(MapTile tile)
        {
            Console.WriteLine("map is rendered vau");
        }
    }
}
