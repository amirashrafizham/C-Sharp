using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //*******************************************************************************
            //WHILE LOOP EXAMPLE
            /*             int emails = 20;
                        while (emails > 0)
                        {
                            emails--;
                            Console.WriteLine(emails);

                            if (emails == 0)
                            {
                                Console.WriteLine("INBOX ZERO ACHIEVED");
                            }
                        } */

            //*******************************************************************************
            //DO WHILE LOOP EXAMPLE
            /*             bool buttonClick = true;

                        do
                        {
                            Console.WriteLine("BLARRRRRRRRR");
                        } while (!buttonClick);

                        Console.WriteLine("Time for a five minute break."); */

            //*******************************************************************************
            //FOR LOOP EXAMPLE
            /*              for (int i = 1; i < 17; i++)
            {
                CreateTemplate(i);
            } */

            //*******************************************************************************

            //FOR EACH LOOP EXAMPLE
            /*             string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

                        foreach (var item in todo)
                        {
                            CreateTodoItem(item);
                        } */

            //*******************************************************************************
            //JUMP STATEMENTS EXAMPLE
            /*             bool buttonClick = true;

                        int counter = 0;
                        do
                        {
                            Console.WriteLine("BLARRRRRRRRR");
                            counter++;
                            if (counter >= 3)
                            {
                                break;
                            }
                        } while (!buttonClick);

                        Console.WriteLine("Time for a five minute break."); */
        }
        static void CreateTemplate(int week)
        {
            Console.WriteLine($"Week {week}");
            Console.WriteLine("Announcements: \n \n \n ");
            Console.WriteLine("Report Backs: \n \n \n");
            Console.WriteLine("Discussion Items: \n \n \n");
        }

        static void CreateTodoItem(string item)
        {
            Console.WriteLine($"[] {item}");
        }
    }
}
