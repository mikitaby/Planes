using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            return (new Random()).Next(359);
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
    

    public class RandomParams
    {
        Random random;

        public RandomParams() 
        {
            random = new Random();
        }

        public double getRandomSpeed()
        {
            return random.NextDouble() + random.Next(5);
        }

        public double getRandomDegree()
        {
            return random.Next(359);
        }

        public string getRandomName()
        {
            return "Борт " + random.Next(1000).ToString();
        }

        public int getRandomStartCoordinate()
        {
            return random.Next(1000);
        }
    }
}
