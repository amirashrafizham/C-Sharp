using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int counter;
            int numInput;
            string message;
            Console.Write("How many times do you want to loop? ");
            numInput = Convert.ToInt32(Console.ReadLine()); 
            
            for (counter = 0; counter<numInput; counter++) {

                message = (counter % 2 == 0) ? "even number" : "odd number";
                Console.WriteLine($"The loop is currently at {counter} and it is an {message}");
            }

            Console.ReadLine();
        }
    }
}