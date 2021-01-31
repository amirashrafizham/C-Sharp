using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "HelloWorld94!";
            bool eightCharacter = false;
            bool lowerCase = false;
            bool upperCase = false;
            bool numerical = false;
            bool symbols = false;

            //To test if Password has 8 character length
            if (test.Length >= 8)
            {
                eightCharacter = true;
            }

            for (int i = 0; i < test.Length; i++)
            {
                //To test if Password has lowercase characters
                if (Char.IsLower(test[i]))
                {
                    lowerCase = true;
                }

                //To test if Password has Uppercase characters 
                if (Char.IsUpper(test[i]))
                {
                    upperCase = true;
                }

                //To test if Password has Numerical characters
                if (Char.IsNumber(test[i]))
                {
                    numerical = true;
                }

                //To test if Password has  Special characters
                if (!Char.IsLetterOrDigit(test[i]))
                {
                    symbols = true;
                }
            }

            if (eightCharacter == false)
            {
                Console.WriteLine("Password has less than 8 characters");
            }

            if (lowerCase == false)
            {
                Console.WriteLine("Password does not have lowercase character");
            }
            if (upperCase == false)
            {
                Console.WriteLine("Password does not have upperchase character");
            }
            if (numerical == false)
            {
                Console.WriteLine("Password does not have numerical character");
            }
            if (symbols == false)
            {
                Console.WriteLine("Password does not have special character");
            }

            if (eightCharacter == true && lowerCase == true && upperCase == true && numerical == true && symbols == true)
            {
                Console.WriteLine("Your password is strong");
            }

            Console.ReadLine(); 
        }
    }
}
