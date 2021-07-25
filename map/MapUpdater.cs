using System;
using static Raylib.Raylib;

namespace _4Elements.map
{
    class MapUpdater
    {
        public void UpdateMap (Map map)
        {
            UpdateTerrain(map);
            UpdateElementals(map);
        }

        private void UpdateTerrain(Map map)
        {
            throw new NotImplementedException();
        }

        private void UpdateElementals(Map map)
        {
            foreach(Elemental elemental in map.elementals)
            {
                elemental.Update(map);
            }
        }
    }
}
