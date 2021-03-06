using System;

namespace StaticMembers
{
    class Forest
    {
        // FIELDS

        public int age;
        private string biome;
        private static int forestsCreated;
        // CONSTRUCTORS

        public Forest(string aName, string aBiome)
        {
            this.Name = aName;
            this.Biome = aBiome;
            Age = 0;
            ForestsCreated += 1;
        }

        public Forest(string name) : this(name, "Unknown")
        { }

        // PROPERTIES

        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
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

        // METHODS

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

        public static int ForestsCreated
        {
            get { return forestsCreated; }
            private set { forestsCreated = value; }
        }

        private static string treeFacts;
        public static string TreeFacts
        {
            get { return treeFacts; }
        }

        public static void PrintTreeFacts()
        {
            Console.WriteLine(TreeFacts);
        }

        static Forest()
        {
            treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
            ForestsCreated = 0;
        }
    }
}