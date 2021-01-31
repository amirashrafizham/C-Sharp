using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("WELCOME TO THE EXQUISITE CORPSE GAME");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n ");
            string mode;
            Console.Write("Would you like to automatically or manually build your monster? [manual / auto]: ");
            mode = Console.ReadLine();

            if (mode.ToLower() == "manual")
            {
                string head;
                string body;
                string feet;

                Console.WriteLine("You can pick either \"Ghost\" \"Bug\" \"Monster\" \n");
                Console.Write("What is the head feature: ");
                head = Console.ReadLine();
                Console.Write("What is the body feature: ");
                body = Console.ReadLine();
                Console.Write("What is the feet feature: ");
                feet = Console.ReadLine();
                Console.WriteLine("\n");
                //Create logic for Head
                switch (head.ToLower())
                {
                    case "ghost":
                        GhostHead();
                        break;
                    case "bug":
                        BugHead();
                        break;
                    case "monster":
                        MonsterHead();
                        break;
                    default:
                        Console.WriteLine("You did not pick its head");
                        break;
                }

                //Create logic for Body
                switch (body.ToLower())
                {
                    case "ghost":
                        GhostBody();
                        break;
                    case "bug":
                        BugBody();
                        break;
                    case "monster":
                        MonsterBody();
                        break;
                    default:
                        Console.WriteLine("You did not pick its body");
                        break;
                }

                //Create logic for Feet
                switch (feet.ToLower())
                {
                    case "ghost":
                        GhostFeet();
                        break;
                    case "bug":
                        BugFeet();
                        break;
                    case "monster":
                        MonsterFeet();
                        break;
                    default:
                        Console.WriteLine("You did not pick feet");
                        break;
                }

                Console.WriteLine("\n");
            }
            else if (mode.ToLower() == "auto")
            {
                //Generating random numbers
                Random rnd = new Random();

                int headRandom = rnd.Next(1, 4);
                int bodyRandom = rnd.Next(1, 4);
                int feetRandom = rnd.Next(1, 4);

                switch (headRandom)
                {
                    case 1:
                        GhostHead();
                        break;
                    case 2:
                        BugHead();
                        break;
                    case 3:
                        MonsterHead();
                        break;
                }

                switch (bodyRandom)
                {
                    case 1:
                        GhostBody();
                        break;
                    case 2:
                        BugBody();
                        break;
                    case 3:
                        MonsterBody();
                        break;
                }

                switch (feetRandom)
                {
                    case 1:
                        GhostFeet();
                        break;
                    case 2:
                        BugFeet();
                        break;
                    case 3:
                        MonsterFeet();
                        break;
                }
            }
            else
            {
                Console.WriteLine("You did not input anything");
            }
        }




        //Monster Features
        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }
        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }
        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }
        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }
        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }
        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }
        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　   (,___,)");
        }
        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }
        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
