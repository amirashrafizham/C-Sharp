using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {

            double gold = 10;
            double silver = 5;
            double bronze = 1;
            int input = 0;

            Console.WriteLine($"Welcome to the Money Maker game.\n1 gold coin is {gold} cents.\n1 silver coin is {silver} cents. \n1 bronze coin is {bronze} cents");
            Console.WriteLine("");
            Console.Write("Please insert a value to check the minimum amount: ");

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Error, you have input a decimal number", e);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Error, the number is out of range", e);
            }

            if (input % gold != 0)
            {
                /*                 double remainder1 = input / gold; //To get the remainder gold coins
                                double numGold = Math.Floor(remainder1); //To round off the remainder

                                double leftOver5 = input - (numGold * gold); //To get the balance of silver and bronze coins coins
                                double remainder2 = leftOver5 / silver; //To get the remainder of silver coins
                                double numSilver = Math.Floor(remainder2);//To round off the remainder

                                double leftOver1 = input - (numGold * gold) - (numSilver * silver);//To get the balance of bronze coins
                                double remainder3 = leftOver1 / bronze;//To get the remainder of bronze coins
                                double numBronze = Math.Floor(remainder3);//To round off the remainder */

                double numGold = Math.Floor(input / gold);
                double moneyLeft = input % gold;
                double numSilver = Math.Floor(moneyLeft / silver);
                moneyLeft = moneyLeft % silver;
                double numBronze = Math.Floor(moneyLeft / bronze);

                Console.WriteLine($"The minimum number to get {input} cents would be\n {numGold} gold coins,\n {numSilver} silver coins,\n {numBronze} bronze coins.");
            }
            else
            {
                Console.WriteLine($"Sorry try again"); //Since gold has the highest value, it has the minimum number of coins to get to input
            }

            Console.ReadLine();
        }
    }
}
