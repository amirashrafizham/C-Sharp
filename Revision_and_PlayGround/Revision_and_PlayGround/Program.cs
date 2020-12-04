using System;

namespace Revision_and_PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times do you want to loop: ");
            int numLoop;
            numLoop = Convert.ToInt32(Console.ReadLine());
            int Counter;
            string message;
            for (Counter = 0; Counter < numLoop; Counter++)
            {
                message = Counter % 2 == 0 ? "Even" : "Odd";
                
                Console.WriteLine($"Now the loop is at : {Counter}, and the number is {message}");
            }
            Console.ReadLine();
        }
    }
}
