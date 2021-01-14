using System;

namespace BasicClasses
{

    class Forest
    {
        //Field class member
        public int age;
        private string biome;

        //Property class member
        public string Name
        {
            get;
            set;
        }

        public int Trees
        {
            get;
            set;
        }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" || value == "Temperate" || value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        //Method class member
        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }

        // Constructors example
        public Forest(string aName, string aBiome)
        {
            this.Name = aName;
            this.Biome = aBiome;
        }

        //Method Overloading example
        public Forest(string aName) : this(aName, "Unknown")
        {
            Console.WriteLine("Unknown");
        }

    }

}