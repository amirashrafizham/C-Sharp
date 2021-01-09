using System;

namespace Revision_and_PlayGround
{
    class Program
    {
        private static void Main(string[] args)

        {
            Console.Write("What is the name of your band? ");
            string bandName = Console.ReadLine();
            Console.Write("How many people are in the band?");
            int bandMember = Console.ReadLine();
            Console.WriteLine("{bandName} has {bandMember} members.");

            Console.ReadLine();
        }
        
    }
}