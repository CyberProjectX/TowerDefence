using System;

namespace TD
{
    public static class RandomHelper
    {
        private static Random random = new Random();

        public static bool WasHappened(float value)
        {
            return random.NextDouble() < value;
        }
    }
}