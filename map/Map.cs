using System;
using System.Collections.Generic;
using static Raylib.Raylib;


namespace _4Elements
{
    class Map
    {
        public MapTile[,] tiles { get; set; }
        public List<Elemental> elementals { get; set; }
        public void GenerateTerrain()
        {
            throw new NotImplementedException();
        }
    }
}
