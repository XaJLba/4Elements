using System;
using static Raylib.Raylib;


namespace _4Elements
{
    class MapTile
    {
        public int terrainHeight
        {
            get
            {
                return terrainHeight;
            }
            set
            {
                if ((value < 0) || (value > 15))
                {
                    throw new ArgumentException($"Value {value} is not in bounds of 0 and 15");
                }
                terrainHeight = value;
            }
        }
        public int waterLevel
        {
            get
            {
                return waterLevel;
            }
            set
            {
                if ((value < 0) || (value > 15))
                {
                    throw new ArgumentException($"Value {value} is not in bounds of 0 and 15");
                }
                waterLevel = value;
            }
        }
        public int natureAmount
        {
            get
            {
                return natureAmount;
            }
            set
            {
                if ((value < 0) || (value > 15))
                {
                    throw new ArgumentException($"Value {value} is not in bounds of 0 and 15");
                }
                natureAmount = value;
            }
        }
        public int fireHeat
        {
            get
            {
                return fireHeat;
            }
            set
            {
                if ((value < 0) || (value > 15))
                {
                    throw new ArgumentException($"Value {value} is not in bounds of 0 and 15");
                }
                fireHeat = value;
            }
        }
    }
}
