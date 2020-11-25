using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int counter;
            int[] arrNumbers = { 4, 8, 15, 16, 23, 42 };
            string suffix;
            for (counter = 0; counter < arrNumbers.Length; counter++)
            {
                switch (counter)
                {
                    case 0:
                        suffix = "th";
                        break;
                    case 1:
                        suffix = "st";
                        break;
                    case 2:
                        suffix = "nd";
                        break;
                    case 3:
                        suffix = "rd";
                        break;
                    default:
                        suffix = "th";
                        break;
                }

                Console.WriteLine($"The {counter}{suffix} value of the array is: {arrNumbers[counter]}");
            }
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