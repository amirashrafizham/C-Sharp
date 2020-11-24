using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int dayNum;
            Console.Write("Insert an integer: ");
            dayNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"It is {GetDay(dayNum)}");
            Console.ReadLine();
        }

        private static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }
            return dayName;
        }
    }
}