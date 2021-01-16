using System;

namespace AlternateExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example using Expression-Bodied Arguments
            Welcome("Earth");
            double days = 500;
            double rotations = DaysToRotations(days);

            //Examples using Method as Argument
            string[] adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };
            string firstLongAdjective = Array.Find(adjectives, IsLong);

            //Example Without Lambda Expressions
            int[] numbers = { 1, 3, 5, 7, 9 };
            bool hasEvenNumbers;
            hasEvenNumbers = Array.Exists(numbers, IsEven);

            //Example With Lambda Expressions  for 1 expression returned
            hasEvenNumbers = Array.Exists(numbers, (int num) => num%2 == 0);

            //Example Lambda Expressions for more than 2 expressions returned) 
            bool mulTwelveAboveTwenty;
            int[] numbersArray = {0, 12};

            mulTwelveAboveTwenty = Array.Exists(numbersArray, (int num) => {
                
                bool mulTwelve = num % 12 == 0;
                bool AboveTwenty = num >= 20;
                return mulTwelve && AboveTwenty;
            });
            //(we have created a function that checks whether an array is multiple of 12 AND above 20)
            Console.ReadLine();

            //Shorter Lambda Expressions
            hasEvenNumbers = Array.Exists(numbers, num => num%2 == 0);
        }
        //Examples using Expression-Bodied Arguments
        static double DaysToRotations(double days) => days / 365;
        static void Welcome(string planet) => Console.WriteLine($"Welcome to planet {planet}");
        static bool IsEven(int number) => number % 2 == 0;
        //Example using Method as Argument
        static bool IsLong(string word)
        {
            return word.Length > 8;
        }
    }
}