using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine(); 
            SayHi(name);
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}