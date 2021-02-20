using System;

namespace test
{
    class Forest
    {
        //Fields chapter
        public int age;
        private string biome; //Public vs Private chapter
        public string name;
        public string trees;

        public string Biome //Properties chapter
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
        public string Name  //Automatic Properties chapter
        {
            get; set;
        }

        public int Trees //Automatic Properties chapter
        {
            get; set;
        }

        public int Age //Get-only Properties chapter
        {
            get { return age; }
            private set { age = value; }
        }

        public int Grow() //Methods chapter
        {
            Trees += 30;
            Age += 1;

            return Trees;
        }
        public int Burn() //Methods chapter
        {
            Trees -= 20;
            Age += 1;

            return Trees;
        }

        public Forest(string aName, string aBiome) //Constructors chapter
        {
            this.Name = aName; //this chapter
            this.Biome = aBiome; //this chapter
            forestsCreated += 1; //Static Fields and Properties chapter
        }

        public Forest(string aName) //Overloading constructors chapter
        {
            this.Name = aName;
            this.Biome = "Unknown";
        }

        private static int forestsCreated; //Static Fields and Properties chapter
        public static int ForestsCreated //Static Fields and Properties chapter
        {
            get { return forestsCreated; }
            private set { forestsCreated = value; }
        }

        private static string treeFacts; //Static Methods chapter
        private static string TreeFacts //Static Methods chapter
        {
            get { return treeFacts; }
        }

        public static void PrintTreeFacts() //Static Methods chapter
        {
            Console.WriteLine(TreeFacts);
        }

        static Forest() //Static Constructors
        {
            treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
        }
    }
}

