using System;

namespace ArchitectArithmetic
{
    public class Program
    {
        static void Main(string[] args)
        {
            double rectangleArea = rectangle(1500, 2500);
            double circleArea = circle(375) / 2;
            double triangleArea = triangle(750, 500);

            double totalAreaCost = (rectangleArea + circleArea + triangleArea) * 180;

            Console.WriteLine($"Rectangle area : {rectangleArea} m2");
            Console.WriteLine($"Circle area    : {circleArea} m2");
            Console.WriteLine($"Triangle area  : {triangleArea} m2");
            Console.WriteLine($"Total Cost     : {totalAreaCost:N2} pesos");
        }

        public static double rectangle(double length, double width) => length * width;
        public static double circle(double radius) => Math.PI * Math.Pow(radius, 2);
        public static double triangle(double baseLength, double heightLength) => 0.5 * baseLength * heightLength;
    }
}
