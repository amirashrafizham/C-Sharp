using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int index = 6;
            while (index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }
            do
            {
                Console.WriteLine("You execute first, then check later");
            } while (index <= 5);
            Console.ReadLine();
        }
    }
}