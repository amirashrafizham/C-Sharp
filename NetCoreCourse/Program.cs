using System;
namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            //  This is to define the numer and size of array
            //  private int[,] myArray = new int[2, 3];


            string[,] array = new string[2, 3];
            array[0, 0] = "One";
            array[0, 1] = "Two";
            array[0, 2] = "Three";
            array[1, 0] = "Four";
            array[1, 1] = "Five";
            array[1, 2] = "Six";

            Console.WriteLine($"The number of rows is : {array.GetUpperBound(0)+1}");
            Console.WriteLine($"The number of columns is : {array.GetUpperBound(1)+1}");

            int counter1;
            int counter2;
            for (counter1 = 0; counter1 <= array.GetUpperBound(0); counter1++)
            {
                for(counter2 = 0; counter2 <= array.GetUpperBound(1); counter2++)
                {
                    Console.WriteLine($"The value of array({counter1},{counter2}) is {array[counter1, counter2]}");
                }
            }
        }

    }
}

/*
    |one  |two  |three|
    |four |five |six  |
*/