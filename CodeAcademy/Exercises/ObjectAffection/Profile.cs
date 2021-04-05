
using System;

namespace CodeCademy_Exercise
{
    class Profile
    {
        private string name;
        private int age;
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value > 18)
                {
                    this.age = value;
                }
                else
                {
                    this.age = 0;
                }
            }
        }
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public Profile(string name, int aAge, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.Age = aAge;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[] { "n/a" };
        }

        public string Validate()
        {

            string biodata = $"Name: {this.name}, \nAge: {this.Age}, \nCity: {this.city}, \nCountry: {this.country}, \nPronouns: {this.pronouns}, \nHobbies: ";

            foreach (var item in hobbies)
            {
                biodata += $"{item}, ";
            }

            return biodata;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    }
}

