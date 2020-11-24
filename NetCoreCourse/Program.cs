using System;
namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;
            if(isMale && isTall)
            {
                Console.WriteLine("You are a tall Male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short Male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not Male but tall");
            }
            else 
            {
                Console.WriteLine("You are neither tall or male or both");
            }
                Console.ReadLine();
        }
    }

}