using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            Console.WriteLine("Giraffe\nAcademy");
            Console.WriteLine("Giraffe\"Academy");
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("academy"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf('f'));
            Console.WriteLine(phrase.Substring(8));
            Console.WriteLine(phrase.Substring(8, 3));
            Console.ReadLine();
        }
    }
}