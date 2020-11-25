using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double count = 1;
            double end = 3;
            double actual = 5;
            GuessNumber(count, end, actual);
            Console.ReadLine();
        }

        private static void GuessNumber(double count, double end, double actual)
        {
            string answer;
            double guess;
            while (count <= end)
            {
                Console.Write("Guess a number: ");
                guess = Convert.ToDouble(Console.ReadLine());
                if (guess == actual)
                {
                    answer = "You are correct";
                    Console.WriteLine(answer);
                    break;
                }
                else
                {
                    if (end - count == 0)
                    {
                        answer = $"You have run out of tries";
                        Console.WriteLine(answer);
                        break;
                    }
                    answer = $"Try again. You have {end - count} guesses remaining";
                    Console.WriteLine(answer);
                    count++;
                }
            }
        }
    }
}