using System;
namespace FruitFarmSimulator
{
    public class Orchard
    {
        public int length { get; }
        public int width { get; }
        public string plant { get; }
        public int yieldMin { get; }
        public int yieldMax { get; }

        public int Harvest()
        {
            Random rand = new Random();
            int sq = length * width;
            return sq * rand.Next(yieldMin, yieldMax);
        }

        public Orchard(int length, int width, string plant, int yieldMin, int yieldMax)
        {
            this.length = length;
            this.width = width;
            this.plant = plant;
            this.yieldMin = yieldMin;
            this.yieldMax = yieldMax;
        }
    }
}
