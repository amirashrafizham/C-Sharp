using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions =  
            {
                "Flying in an aeroplane is statistically safer than driving in a car",

                "A metre is further than a yard",

                "The mathematical name for the shape of a Pringle is hyperbolic paraboloid",

                "The Great Wall of China is visible from space",

                "Donald Duck’s middle name is Fauntelroy"
            };
            bool[] answers = {
                true,
                true,
                true,
                false,
                true,
            };
            bool[] responses = new bool[5];

            //Loop to store answer into an array
            for(int i = 0; i < questions.Length; i++)
            {
                bool userAnswer;
                bool isBool = true;

                Console.WriteLine(questions[i]);
                do
                {
                    Console.Write("True or False: ");
                    isBool = Boolean.TryParse(Console.ReadLine(),out userAnswer);
                } while (isBool == false);
                Console.Write("\n");
                answers[i] = userAnswer;
            }

            //Loop to calculate the score
            int userScore = 0;

            for (int i = 0; i < answers.Length ; i++)
            {
               if(answers[i] == responses[i])
               {
                   userScore += 1;
               }
            }
            Console.WriteLine("****************************************************************");
            //Present overall score
            Console.WriteLine($"Congratulations, you have scored {userScore}");
            for (int i = 0; i < responses.Length; i++)
            {
                Console.WriteLine($"For question {i+1}: {questions[i]}");
                Console.WriteLine($"You answered {responses[i]}");
                Console.WriteLine($"Correct answer {answers[i]}");
                Console.WriteLine("\n");
            }
            Console.WriteLine("****************************************************************");
        }
    }
}
