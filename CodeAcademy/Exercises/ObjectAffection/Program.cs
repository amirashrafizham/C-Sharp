using System;

namespace CodeCademy_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 18, "New York", "USA", "he/him");
            Console.WriteLine(sam.Validate());
            sam.SetHobbies(new string[] { "playing guitar", "jogging", "playing guitar" }); //NEW is needed to INITIALIZE the string array. Wihout it, it doesn't consider it as an array
            Console.WriteLine(sam.Validate());

        }
    }
}
