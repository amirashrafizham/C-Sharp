using System;

namespace Revision_and_PlayGround
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int actualNumber;
            int guessNumber;
            int loopNumber = 3;
            int min = 0;
            int max = 5;
            int counter;
            Random rd = new Random();
            actualNumber = rd.Next(min, max);
            Console.WriteLine("The actual number is " + actualNumber);

            for (counter = 0; counter < loopNumber; counter++)
            {
                Console.Write("Pick a number between 1-5: ");
                guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber == actualNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            }

            Console.ReadLine();

            // Console.Write($"{numberGuessing(guessNumber, actualNumber)}. The actual number is {actualNumber}  ");
        }

        /*
                private static string numberGuessing(int guessNumber, int actualNumber)
                {
                    string message;
                    message = (guessNumber == actualNumber) ? "Equals" : "Not Equals";
                    return message;
                }
        */
    }
}