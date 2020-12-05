using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int baseNumber;
            int powerNumber;


            Console.Write("Provide your base number: ");
            baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Provide the power: ");
            powerNumber = Convert.ToInt32(Console.ReadLine());


            ExponentMethod(baseNumber, powerNumber);
        }
        private static void ExponentMethod(int baseNumber, int powerNumber)
        {
            int counter;
            int result = 1;
            for (counter = 0; counter<powerNumber; counter++)
            {
                result = result * baseNumber; 
            }
            Console.WriteLine($"{baseNumber} to the power of {powerNumber} is {result}");
        }
    }
}