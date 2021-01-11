using System;
using System.Linq;
namespace ActiveRecall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array1[i] = i + 2;
                Console.WriteLine(array1[i]);
            }
            int mulArray = 1;

            for (int i = 0; i < array1.Length; i++)
            {
                mulArray = mulArray * array1[i];
            }
            Console.WriteLine($"The sum of all array elements is {array1.Sum()}");
            Console.WriteLine($"The multiplication  of all array elements is {mulArray}");
            Console.ReadLine();
        }
    }
}
