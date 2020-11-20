using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(50);
            Console.WriteLine(50 % 8);
            Console.WriteLine(4 + 2 * 6);
            Console.WriteLine(5.1 + 8.1);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5 / 2.0);
            int num = 6;
            num++;
            Console.WriteLine(num);
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(36,40));
            Console.WriteLine(Math.Round(36.8));
            Console.ReadLine();
        }
    }
}