using System;
using System.Diagnostics;

namespace CaesarCipher
{
    public class CompareSolution
    {
        public static void NewSolution(string password, int key)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            char[] passwordArr = password.ToLower().ToCharArray();
            char[] encryptArr = new char[passwordArr.Length];

            string charLimit = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < passwordArr.Length; i++)
            {
                for (int j = 0; j < charLimit.Length; j++)
                {
                    if (passwordArr[i] == charLimit[j] && (j + key < charLimit.Length))
                    {
                        encryptArr[i] = charLimit[j + key];
                    }
                    else if (passwordArr[i] == charLimit[j] && (j + key > charLimit.Length))
                    {
                        encryptArr[i] = charLimit[j - charLimit.Length + key];
                    }
                    else if (char.IsNumber(passwordArr[i]))
                    {
                        encryptArr[i] = passwordArr[i];
                    }
                    else if (!char.IsLetterOrDigit(passwordArr[i]))
                    {
                        encryptArr[i] = passwordArr[i];
                    }
                }
            }
            string newPassword = new String(encryptArr);

            System.Console.WriteLine($"The new password is: {newPassword}");
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time for new solution is {0} ms", stopwatch.ElapsedMilliseconds);
        }

        public static void OldSolution(string password, int key)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

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
            Console.WriteLine($"Your encrypted password is: {newPassword}");
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time for old solution is {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}