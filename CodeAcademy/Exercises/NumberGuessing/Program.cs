using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random _random = new Random();
            int correctNumber = _random.Next(1, 11);
            int guessNumber = 0;
            string inputUser;
            int guesses = 5;
            bool win = false;


            for (int i = 1; i <= guesses; i++)
            {

                try
                {
                    do
                    {
                        Console.Write("Guess a number: ");
                        inputUser = (Console.ReadLine());
                    } while (!CheckInt(inputUser));

                    guessNumber = Convert.ToInt32(inputUser);
                }

                catch (System.FormatException e)
                {
                    Console.WriteLine("That was not a number", e);
                }

                if (correctNumber == guessNumber)
                {
                    win = true;
                    break;
                }
                else
                {
                    if (i != guesses)
                    {
                        Console.WriteLine($"Wrong! You have {guesses - i} tries left");
                    }
                    else
                    {
                        Console.WriteLine("You have run out of tries");
                    }
                }
            }

            if (win)
            {
                Console.WriteLine("Congrats! You guessed it correctly");
            }
            else
            {
                Console.WriteLine($"Thanks for playing. The correct answer is {correctNumber}");
            }
        }

        static bool CheckInt(string inputUser)
        {
            int guessNumber;
            bool success;
            success = int.TryParse(inputUser, out guessNumber);

            if (!success)
            {
                Console.WriteLine("Not an interger! Try again. ");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}

