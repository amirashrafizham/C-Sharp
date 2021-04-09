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

            //ask user whether to encrypt or decrypt
            Console.Write("Select Encrypt or Decrypt: ");
            string answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                case "encrypt":
                    Encrypt();
                    break;
                case "decrypt":
                    Decrypt();
                    break;
                default:
                    Console.WriteLine("You did not select anything");
                    break;
            }
            static void Encrypt()
            {
                char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                Console.Write("Please type password to encrypt: ");
                string password = Console.ReadLine().ToLower();

                Console.Write("Please type your key: ");
                int key = Convert.ToInt32(Console.ReadLine());

                char[] passArray = password.ToCharArray(); //to separate string into character array
                char[] newArray = new char[password.Length]; //to store encrypted password in an array

                for (int i = 0; i < passArray.Length; i++)
                {
                    char newChar;
                    int getIndex = Array.IndexOf(alphabet, passArray[i]);
                    if (getIndex == -1)
                    {
                        newArray[i] = passArray[i];
                    }
                    else
                    {
                        int newIndex = getIndex + key;

                        if (newIndex > 26)
                        {
                            newChar = alphabet[newIndex - 26];
                        }
                        else
                        {
                            newChar = alphabet[getIndex + key];
                        }
                        newArray[i] = newChar;
                    }
                }

                string newPassword = String.Join("", newArray);
                Console.Write($"Your encrypted password is: {newPassword}");
            }

            static void Decrypt()
            {
                char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                Console.Write("Please type password to decrypt: ");
                string password = Console.ReadLine().ToLower();

                Console.Write("Please type your key: ");
                int key = Convert.ToInt32(Console.ReadLine());


                char[] passArray = password.ToCharArray(); //to separate string into character array
                char[] newArray = new char[password.Length]; //to store encrypted password in an array

                for (int i = 0; i < passArray.Length; i++)
                {
                    char newChar;
                    int getIndex = Array.IndexOf(alphabet, passArray[i]);
                    if (getIndex == -1)
                    {
                        newArray[i] = passArray[i];
                    }
                    else
                    {
                        int newIndex = getIndex - key;

                        if (newIndex < 0)
                        {
                            newChar = alphabet[newIndex + 26];
                        }
                        else
                        {
                            newChar = alphabet[getIndex - key];
                        }
                        newArray[i] = newChar;
                    }
                }

                string newPassword = String.Join("", newArray);
                Console.Write($"Your decrypted password is: {newPassword}");
            }

        }
    }
}
