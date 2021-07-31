using System;

namespace _4Elements
{
    class MapTile
    {
        public byte natureThicketness
        {
            get
            {
                return natureThicketness;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentOutOfRangeException();
                }
                natureThicketness = value;
            }
        }
        public byte waterDepth
        {
            get
            {
                return waterDepth;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentOutOfRangeException();
                }
                waterDepth = value;
            }
        }
        public byte terrainHeight
        {
            get
            {
                return terrainHeight;
            }
            set
            {
                if ((value > 15))
                {
                    throw new ArgumentOutOfRangeException();
                }
                terrainHeight = value;
            }
        }
        public byte fireHeat
        {
            get
            {
                return fireHeat;
            }
            set
            {
                if ((value > 15))
                {
                    throw new ArgumentOutOfRangeException();
                }
                fireHeat = value;
            }
        }

        public MapTile(byte natureThicketness, byte waterDepth, byte terrainHeight, byte fireHeat)
        {
            this.natureThicketness = natureThicketness;
            this.waterDepth = waterDepth;
            this.terrainHeight = terrainHeight;
            this.fireHeat = fireHeat;
        }
    }
}
