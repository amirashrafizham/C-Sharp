using System;

namespace ArchitectArithmetic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a city to calculate its cost to build");
            Console.WriteLine("(1) Teotihuacan \n(2) Taj Mahal \n(3) Mecca");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Teotihuacan();
                        break;

                    case 2:
                        TajMahal();
                        break;

                    case 3:
                        Mecca();
                        break;
                    default:
                        Console.WriteLine("You did not select an option");
                        break;
                }
            }
            catch (System.Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        static void Teotihuacan()
        {

            double recArea = RectangleArea(1500, 2500);
            double cirArea = CircleArea(4);
            double triArea = TriangleArea(750, 500);
            Console.WriteLine($"The area of rectangle is {recArea:N2}");
            Console.WriteLine($"The area of circleis {cirArea:N2}");
            Console.WriteLine($"The area of triangl is {triArea:N2}");
            double totalAreaCost = (recArea + cirArea + triArea) * 180;
            Console.WriteLine($"The total area cost is {totalAreaCost:N2} pesos");
        }

        static void TajMahal()
        {

            double recArea = RectangleArea(90.5, 90.5);
            double triArea = TriangleArea(24, 24) * 4;
            Console.WriteLine($"The area of rectangle is {recArea:N2}");
            Console.WriteLine($"The area of triangle is {triArea:N2}");
            double totalAreaCost = (recArea - triArea) * 180;
            Console.WriteLine($"The total area cost is {totalAreaCost:N2} pesos");
        }

        static void Mecca()
        {

            double recArea1 = RectangleArea(264, 284);
            double recArea2 = RectangleArea(180, 106);
            double triArea = TriangleArea(84, 264);
            Console.WriteLine($"The area of rectangle is {recArea1:N2}");
            Console.WriteLine($"The area of rectangle is {recArea2:N2}");
            Console.WriteLine($"The area of triangle is {triArea:N2}");
            double totalAreaCost = (recArea1 - triArea + recArea2) * 180;
            Console.WriteLine($"The total area cost is {totalAreaCost:N2} pesos");
        }
        static double RectangleArea(double length, double width) => length * width;
        static double CircleArea(double radius) => Math.PI * Math.Pow(radius, 2);
        static double TriangleArea(double baseT, double heightT) => 0.5 * baseT * heightT;


    }
}
