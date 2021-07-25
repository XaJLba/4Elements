﻿using System.Numerics;

namespace _4Elements
{
    abstract class Elemental
    {
        public Vector2 position { get; private set; }
        public int timeLeftToLive { get; private set; }
        public abstract void Update(Map map);
    }
}
