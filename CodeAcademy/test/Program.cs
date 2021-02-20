using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            DumbellCalculator();
        }

        static void Calculator(int num1, int num2)
        {
            int add = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;

            Console.WriteLine("");
            Console.WriteLine($"The addition of {num1} and {num2} is {add}");
            Console.WriteLine($"The substraction of {num1} and {num2} is {sub}");
            Console.WriteLine($"The multiplication of {num1} and {num2} is {mul}");
            Console.WriteLine($"The division of {num1} and {num2} is {div}");
        }

        static void FizzBuzz()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.Write("FizzBuzz" + " ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz" + " ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz" + " ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }

        static void MoneyMaker()
        {
            int gold = 10;
            int silver = 5;
            int bronze = 1;

            Console.WriteLine($"Gold is {gold} cents");
            Console.WriteLine($"Silver is {silver} cents");
            Console.WriteLine($"Bronze is {bronze} cents\n");

            Console.Write("Give a value: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{number} cents would take: ");
            double bal_gold = number % gold;
            double bal_silver = bal_gold % silver;
            double bal_bronze = bal_silver % bronze;


            Console.WriteLine(Math.Floor(number / gold) + " gold coins");
            Console.WriteLine(Math.Floor(bal_gold / silver) + " silver coins");
            Console.WriteLine(Math.Floor(bal_silver / bronze) + " bronze coins");

            Console.ReadLine();
        }

        static void PasswordChecker()
        {

            Console.WriteLine("Enter a password:");
            string pwd = Console.ReadLine();
            char[] pwdArray = pwd.ToCharArray();

            bool pwdArrayLength = false;
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;
            bool hasSpecial = false;

            if (pwdArray.Length > 8)
            {
                pwdArrayLength = true;
            }

            for (int i = 0; i < pwdArray.Length; i++)
            {
                if (Char.IsUpper(pwdArray[i]))
                {
                    hasUpper = true;
                }

                if (Char.IsLower(pwdArray[i]))
                {
                    hasLower = true;
                }

                if (Char.IsNumber(pwdArray[i]))
                {
                    hasNumber = true;
                }

                if (!Char.IsLetterOrDigit(pwdArray[i]))
                {
                    hasSpecial = true;
                }
            }

            if (!pwdArrayLength)
            {
                Console.WriteLine("Your password is less than 8 characters");
            }
            if (!hasUpper)
            {
                Console.WriteLine("Your password does not have an Upper Case");
            }
            if (!hasLower)
            {
                Console.WriteLine("Your password does not have a Lower Case");
            }
            if (!hasNumber)
            {
                Console.WriteLine("Your password does not have a Number");
            }
            if (!hasSpecial)
            {
                Console.WriteLine("Your password does not have any Special Characters");
            }


            if (pwdArrayLength && hasLower && hasNumber && hasUpper && hasSpecial)
            {
                Console.WriteLine("Strong Password");
            }
            else
            {
                Console.WriteLine("Weak Password");
            }

            Console.ReadLine();
        }


        static void DumbellCalculator()
        {

            Console.Write("Insert a single dumbell weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double[] platePair = { 2, 4, 6, 8 }; //How many plates pair
            double fiveMult = 0; //multiplier for 5 kg
            double twoMult = 0; //multiplier for 2kg
            double oneMult = 0; //multiplier for 1kg
            double halfMult = 0; //multiplier for 0.5kg

            // Check for 5 kg
            for (int i = 0; i < platePair.Length; i++)
            {
                if ((platePair[i] * 5) <= weight)
                {
                    fiveMult = platePair[i];
                }
            }

            double remainder;
            remainder = weight - fiveMult * 5; //remainder after 5kg pair is used

            //Check for 2 kg
            for (int i = 0; i < platePair.Length; i++)
            {
                if ((platePair[i] * 2) <= remainder)
                {
                    twoMult = platePair[i];
                }
            }

            remainder = remainder - twoMult * 2; //remainder after 2kg pair is used

            //Check for 1 kg
            for (int i = 0; i < platePair.Length; i++)
            {
                if ((platePair[i] * 1) <= remainder)
                {
                    oneMult = platePair[i];
                }
            }

            remainder = remainder - oneMult * 1; //remainder after 1kg pair is used

            //Check for 0.5 kg
            for (int i = 0; i < platePair.Length; i++)
            {
                if ((platePair[i] * 0.5) <= remainder)
                {
                    halfMult = platePair[i];
                }
            }

            remainder = remainder - halfMult * 0.5; //remainder after 0.5kg pair is used

            Console.WriteLine($"\n");
            Console.WriteLine($"For {weight}kg single dumbell: ");
            Console.WriteLine($"\n");
            Console.WriteLine($"The number of 5kg pair is: {fiveMult} ({fiveMult * 5} kg)");
            Console.WriteLine($"The number of 2kg pair is: {twoMult} ({twoMult * 2} kg)");
            Console.WriteLine($"The number of 1kg pair is: {oneMult} ({oneMult * 1} kg)");
            Console.WriteLine($"The number of 0.5kg pair is: {halfMult} ({halfMult * 0.5} kg)");
            Console.WriteLine($"\n");


        }
    }
}
