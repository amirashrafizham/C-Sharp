using System;
namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Pick a number to find its cubed value: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The cubed value of {num} is {cube(num)}");
            Console.ReadLine();
        }

        private static double cube(double num)
        {
            double result = num* num* num;
            return result;
        }
    }
}