using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile profile1 = new Profile("Amir", 26, "Kuala Lumpur", "Malaysia", "He/Him");
            Profile profile2 = new Profile("Ashraf", -1, "Manchester", "United Kingdom", "He/Him");
            Console.WriteLine(Profile.CountProfile);
            profile1.AddHobbies("Guitar", "Piano");
            profile2.AddHobbies("Coding", "Gym");
            profile1.GetProfile();
            profile2.GetProfile();
            Console.ReadLine();
        }
    }
}
