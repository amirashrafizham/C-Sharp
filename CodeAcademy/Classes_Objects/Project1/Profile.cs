// This is for the Object of Your Affection exercise
using System;

namespace Project1
{
    class Profile
    {
        //Fields
        public string name;
        public int age;
        public string city;
        public string country;
        public string pronoun;
        public string[] hobbies = new string[5];

        private static int countProfile;
        public Profile(string aName, int aAge, string aCity, string aCountry, string aPronoun)
        {
            Console.WriteLine("New profile created");
            name = aName;
            Age = aAge;
            city = aCity;
            country = aCountry;
            pronoun = aPronoun;
            CountProfile++;
        }

        //Property to check whether negative value or not
        private int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        //Static Property to count the number of profiles created
        public static int CountProfile
        {
            get { return countProfile; }
            private set
            {
                countProfile = value;
            }
        }

        //Method to View user profile 
        public void GetProfile()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Pronoun: " + pronoun);
            Console.WriteLine("Hobbies: ");
            for (int i = 0; i < hobbies.Length; i++)
            {
                
            Console.Write($"{hobbies[i]} ");
            }
            Console.WriteLine("\n");
        }

        //Method to add Hobbies
        public void AddHobbies(params string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                hobbies[i] = args[i];
            }
        }
    }
}