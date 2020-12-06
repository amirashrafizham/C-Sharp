using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                //What happens when you divide it by zero? You will get an error right?
                //What happens if you don't put a number as well?
                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                //Instead of breaking the program, we will write the error
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                //Instead of breaking the program, we will write the error
                Console.WriteLine(e.Message);
            }
           Console.ReadLine();
        }
    }
}