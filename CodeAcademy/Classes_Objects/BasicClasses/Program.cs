using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest forest1 = new Forest("Rendelsham");
            Forest forest2 = new Forest("Sahara", "Desert");

            Console.WriteLine(forest1.Biome);

            Console.ReadLine();
        }
    }
}