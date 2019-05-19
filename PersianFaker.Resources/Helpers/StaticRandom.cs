using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PersianFaker.Resources.Helpers
{
    public static class StaticRandom
    {
        private static Random random;
        static StaticRandom()
        {
            random = new Random();
        }

        public static long GetNextRandomNumber(int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}
