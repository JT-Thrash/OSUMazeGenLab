using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThrashJT.Lab3
{

    public static class Seed
    {

        private static System.Random randomGenerator;

        public static void SetSeed(int seedNum)
        {
            randomGenerator = new System.Random(seedNum);
        }


        public static int Next(int min, int max)
        {
            return randomGenerator.Next(min, max);
        }

        public static int Next(int max)
        {
            return randomGenerator.Next(max);
        }


        public static double NextDouble()
        {
            return randomGenerator.NextDouble();
        }
    }
}

