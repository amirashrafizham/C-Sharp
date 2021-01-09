using System;

namespace _1_AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial_NoRecursion(6);

            int rec_Factorial = Factorial_Recursion(6);
            Console.WriteLine(rec_Factorial);
            Console.ReadLine();

        }

        static void Factorial_NoRecursion(int n)
        {
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                x = x * i;
            }
            Console.WriteLine($"The factorial of {n} is {x}");
        }

        static int Factorial_Recursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial_Recursion(n - 1);
        }

    }
}