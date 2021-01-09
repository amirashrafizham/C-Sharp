using System;

namespace Interactive_Using_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the name of your band? ");
            string nameBand = Console.ReadLine();
            Console.Write("How many people are in your band? ");
            int memberBand = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nameBand} has {memberBand} members");
            Console.ReadLine();
        }
    }
}
