using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "The Kill" };
            int[] ratings = new int[] { 5, 4, 4, 3, 3, 5, 5, 4 };

            /*             if (summerStrut.Length == 8)
                        {
                            Console.WriteLine("summerStrut Playlist is ready to go!");
                        }
                        else if (summerStrut.Length > 8)
                        {
                            Console.WriteLine("Too many songs!");
                        }
                        else
                        { 
                            Console.WriteLine("Add some songs!");
                        } */

            int threeStars = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {threeStars} is rated 3 stars");
            string firstTen = Array.Find(summerStrut, (element) => element.Length > 10);
            Console.WriteLine($"The first song that has more than 10 characters in the title is {firstTen}.");

            Array.Sort(summerStrut);
            
            Console.WriteLine($"First element: {summerStrut[summerStrut.GetLowerBound(0)]} and last element {summerStrut[ratings.GetUpperBound(0)]}");


            string[] summerStrutCopy = new string[8];
            Array.Copy(summerStrut, summerStrutCopy, 7);
            Console.WriteLine($"Copied array first element: {summerStrutCopy[0]} and last element: {summerStrutCopy[1]} ");


            Array.Reverse(summerStrut);
            Console.WriteLine($"Reversed summerStrut array {summerStrut[0]}{summerStrut[1]} ");

            Array.Clear(ratings,0,7);
            Console.WriteLine($"Cleared array first element {ratings[0]} and {ratings[7]}");
        }
    }
}
