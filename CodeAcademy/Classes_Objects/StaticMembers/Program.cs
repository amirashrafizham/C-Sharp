using System;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest forest1 = new Forest("Amazon", "Tropical");
            Forest forest2 = new Forest("Sahara", "Desert");

            Console.WriteLine(Forest.ForestsCreated);
            Console.WriteLine(Math.PI);
            Forest.PrintTreeFacts();
        }
    }
}
