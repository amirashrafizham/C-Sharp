using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int actual = 5;
            GuessNumber(actual);
            Console.ReadLine();
        }

        private static void GuessNumber(int actual)
        {
            string answer;
            int guess;
            do
            {
                Console.Write("Guess a number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == actual)
                {
                    answer = "You are correct";
                    Console.WriteLine(answer);
                    break; 
                }
                else
                {
                    answer = "Try again";
                    Console.WriteLine(answer);
                }
            } while (guess != actual);
        }
    }
}