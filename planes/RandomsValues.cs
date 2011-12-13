using System;

namespace planes
{
    public static class RandomsValues
    {
        public static double getRandomSpeed()
        {
            return (new Random()).NextDouble() + (new Random()).Next(5);
        }

        public static double getRandomDegree()
        {
            return (new Random()).NextDouble() + (new Random()).Next(5);
        }

        public static string getRandomName()
        {
            return "Борт " + (new Random()).Next(1000).ToString();
        }

        public static int getRandomStartCoordinate()
        {
            return (new Random()).Next(1000);
        }
    }
}
