using System;

namespace pulsee.engine.Math.Generation
{
    class Random
    {
        public static int RandomInt(int min = 0, int max = Int32.MaxValue) 
        {
            System.Random random = new System.Random();
            return random.Next(min, max);
        }
    }
}
