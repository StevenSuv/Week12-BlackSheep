using System;
using System.IO;

namespace FruitAndVeggies
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitPath = @"\Users\opilane\samples\fruit.txt";
            string[] veggieData = File.ReadAllLines(fruitPath);

            string veggiePath = @"\Users\opilane\samples\veggie.txt";
            string[] fruitData = File.ReadAllLines(veggiePath);

            File.WriteAllLines(fruitPath, fruitData);
            File.WriteAllLines(veggiePath, veggieData);

        }
    }
}
