using System;

namespace CodeCademy_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 18, "New York", "USA", "he/him");
            Console.WriteLine(sam.Validate());

        }
    }
}
