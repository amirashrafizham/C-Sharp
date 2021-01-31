using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("WELCOME TO THE CAESAR CIPHER GAME");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n ");

            //We now get the password from the user
            Console.Write("Type a password to encrypt: ");
            string password = Console.ReadLine();
            char[] original = password.ToCharArray();

            //We no retrieve the key
            Console.Write("What is the key: ");
            int key = Convert.ToInt32(Console.ReadLine());

            //We create an array to store char into numeric
            int[] storeNumeric = new int[original.Length];

            //We create an array to store the computed numeric alphabets
            char[] encrypt = new char[original.Length];

            //Generating the encryption
            for (int i = 0; i < original.Length; i++)
            {
                storeNumeric[i] = (int)original[i] + key;
                encrypt[i] = (char)storeNumeric[i];
            }
            //Displaying the encrypted password
            string encryptString = String.Join("", encrypt);
            Console.WriteLine($"The Encrypted Password is : {encryptString}");

            Console.Write("Would you like to decrypt the password [yes/no]: ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {

                //Decrypting the encrypted password
                for (int i = 0; i < encrypt.Length; i++)
                {
                    storeNumeric[i] = (int)encrypt[i] - key;
                    original[i] = (char)storeNumeric[i];
                }
                //Displaying the decrypted password
                string decryptString = String.Join("", original);
                Console.WriteLine($"The Decrypted Password is : {decryptString}");

            }
            else
            {
                Console.WriteLine("Thank you and have a great day!");
            }
        }
    }
}
