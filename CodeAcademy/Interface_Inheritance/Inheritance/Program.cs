using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan car1 = new Sedan(20);
            Truck truck1 = new Truck(20, 500);
            Bicycle bike1 = new Bicycle(-10);

            Console.WriteLine(car1.Describe());
            Console.WriteLine(truck1.Describe());
            Console.WriteLine(bike1.Describe());
        }
    }
}
