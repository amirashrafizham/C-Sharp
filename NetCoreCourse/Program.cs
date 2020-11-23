using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Pick a color: ");
            string color = Console.ReadLine();
            Console.Write("Pick a noun: ");
            string pluralNoun = Console.ReadLine();
            Console.Write("Pick a celebrity: ");
            string celebrity = Console.ReadLine();
            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I Love {celebrity}");
        }
    }
}