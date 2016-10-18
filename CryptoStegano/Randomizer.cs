using System;
using System.Collections.Generic;

namespace CryptoStegano
{
    class Randomizer
    {
        private Randomizer() { }
        public static Randomizer Instance { get; } = new Randomizer();
        
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public int Next(int minValue, int maxValue)
        {
            lock(syncLock)
            {
                return random.Next(minValue, maxValue);
            }
        }

        public int Next(int maxValue)
        {
            lock(syncLock)
            {
                return random.Next(maxValue);
            }
        }
    }
}
