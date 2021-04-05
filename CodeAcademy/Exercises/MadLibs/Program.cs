using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                  This program is to write a MadLibs word Game
                  Author: Amir Ashraf Izham 
            */

            // Let the user know that the program is starting:

            Console.WriteLine("The program is starting now\n ");

            // Give the Mad Lib a title:
            string title = "The Chaos in KL";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.Write("Write the first adjective: ");
            string adj1 = Console.ReadLine();

            Console.Write("Write the second adjective: ");
            string adj2 = Console.ReadLine();

            Console.Write("Write the third adjective: ");
            string adj3 = Console.ReadLine();

            Console.Write("Write the first verb: ");
            string verb = Console.ReadLine();

            Console.Write("Write the first noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Write the second noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Name an animal: ");
            string animal = Console.ReadLine();

            Console.Write("Name a food: ");
            string food = Console.ReadLine();

            Console.Write("Name a fruit: ");
            string fruit = Console.ReadLine();

            Console.Write("Name a superhero: ");
            string superhero = Console.ReadLine();

            Console.Write("Name a country: ");
            string country = Console.ReadLine();

            Console.Write("Name a dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Name a year: ");
            int year = Convert.ToInt32(Console.ReadLine());




            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

        }
    }
}
