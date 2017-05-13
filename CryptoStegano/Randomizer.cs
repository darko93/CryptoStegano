using System;
using System.Collections.Generic;

namespace CryptoStegano
{
    static class Randomizer
    {        
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public static int Next(int minValue, int maxValue)
        {
            lock(syncLock)
            {
                return random.Next(minValue, maxValue);
            }
        }

        public static int Next(int maxValue)
        {
            lock(syncLock)
            {
                return random.Next(maxValue);
            }
        }
    }
}
