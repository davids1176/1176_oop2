using System;

namespace FruitFarmSimulator
{
    class FarmApp
    {
        static string[] plants = { "apple", "peach", "pear", "plum", "cherry" };
    
        static void Run()
        {
            Orchard[] orchards = new Orchard[20];
            int[] yields = new int[orchards.Length];
            int[] plantYields = new int[plants.Length];

            for (int i = 0; i < orchards.Length; i++)
            {
                Random rand = new Random();
                int plantId = rand.Next(0, plants.Length);
                Orchard orchard = new Orchard(rand.Next(0, 20), rand.Next(0, 20), plants[plantId], rand.Next(0, 20), rand.Next(40, 100));
                orchards[i] = orchard;
                yields[i] = orchard.Harvest();
                plantYields[plantId] = yields[i];
            }

            for (int i = 0; i < plants.Length; i++)
            {
                Console.WriteLine(plants[i] + ": " + plantYields[i] + " Kg");
            }
        }

        public static void Main(string[] args)
        {
            Run();
        }
    }
}
