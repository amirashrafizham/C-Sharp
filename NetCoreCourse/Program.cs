using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double answer;
            Console.Write("Pick your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pick your first number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pick your operator: ");
            string op = Console.ReadLine();
            if (op == "+")
            {
                answer = num1 + num2;
                Console.Write($"The addition of {num1} and {num2} is {answer}");
            }
            else if (op == "-")
            {
                answer = num1 - num2;
                Console.Write($"The substraction of {num1} and {num2} is {answer}");
            }
            else if (op == "*")
            {
                answer = num1 * num2;
                Console.Write($"The multiplication of {num1} and {num2} is {answer}" );
            }
            else if (op == "/")
            {
                answer = num1 / num2;
                Console.Write($"The division of {num1} and {num2} is {answer}");
            }
            else
            {
                Console.Write("You have not entered the right operator");
            }
            Console.ReadLine();
        }
    }
}