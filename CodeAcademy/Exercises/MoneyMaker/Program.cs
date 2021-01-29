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

            Console.WriteLine($"Welcome to the Money Maker game.\n1 gold coin is {gold} cents.\n1 silver coin is {silver} cents. \n1 bronze coin is {bronze} cents");
            Console.WriteLine("");
            Console.Write("Please insert a value to check the minimum amount: ");
            
            int input = Convert.ToInt32(Console.ReadLine());

            if (input % gold != 0)
            {
                double remainder1 = input / gold; //To get the remainder gold coins
                double numGold = Math.Floor(remainder1); //To round off the remainder


                double leftOver5 = input - (numGold * gold); //To get the balance of silver and bronze coins coins
                double remainder2 = leftOver5 / silver; //To get the remainder of silver coins
                double numSilver = Math.Floor(remainder2);//To round off the remainder

                double leftOver1 = input - (numGold * gold) - (numSilver * silver);//To get the balance of bronze coins
                double remainder3 = leftOver1 / bronze;//To get the remainder of bronze coins
                double numBronze = Math.Floor(remainder3);//To round off the remainder
                Console.WriteLine($"The minimum number to get {input} cents would be {numGold} gold coins, and {numSilver} silver coins, and {numBronze} bronze coins.");
            }
            else
            {
                Console.WriteLine($"The minimum number to get {input} cents would be {input / gold} gold coins"); //Since gold has the highest value, it has the minimum number of coins to get to input
            }

            Console.ReadLine();
        }
    }
}
