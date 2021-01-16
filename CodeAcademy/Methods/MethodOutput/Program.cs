using System;

namespace MethodOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jupyter");
            int ageAsInt;
            bool outcome;

            int nameAsInt;
            bool outcome2;

            string ageAsString = "102";
            string nameAsString = "Granny";

            outcome = Int32.TryParse(ageAsString, out ageAsInt);
            outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
/* 
            Console.WriteLine($"{outcome} {ageAsInt}");
            Console.WriteLine($"{outcome2} {nameAsInt}"); */

            bool check;
            string message ="WEY PUKIMAK";
            Console.WriteLine(Whisper(message, out check));

            Console.ReadLine();
        }

        static string DecoratePlanet(string planet)
        {
            return $"\"*.*.* Welcome to {planet}*.*.*\""; // this "\" is called an escape sequence in C#
        }

        static string Whisper(string param1, out bool check)
        {
            check = true;
            return param1.ToLower();
        }
    }
}
