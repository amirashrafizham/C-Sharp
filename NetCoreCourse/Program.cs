using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Pick your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pick your first number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MaxNumber(num1, num2));
            Console.ReadLine();
        }

        private static string MaxNumber(int num1, int num2)
        {
            string answer;
            if (num1 > num2)
            {
               answer = $"{num1} is larger than {num2}";
            }
            else
            {
                answer = $"{num2} is larger than {num1}";
            }

            return answer; 
        }
    }
}