using System;

namespace _5_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int x = 0;
            //your code goes here

            foreach (var item in words)
            {
                if (item.Contains(letter))
                {
                    Console.WriteLine(item);
                }
                else
                {

                    x = x + 1;

                }
            }
            if (x == words.Length)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
