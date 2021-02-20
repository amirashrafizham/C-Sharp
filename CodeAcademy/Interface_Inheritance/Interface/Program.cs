using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan(60);
            Sedan sedan2 = new Sedan(70);
            Truck truck1 = new Truck(45, 500);

            Console.WriteLine($"Sedan 1: {sedan1.Speed}, {sedan1.Wheels}, {sedan1.LicensePlate}");
            Console.WriteLine($"Sedan 2: {sedan2.Speed}, {sedan2.Wheels}, {sedan2.LicensePlate}");
            Console.WriteLine($"Truck 1: {truck1.Speed}, {truck1.Wheels}, {truck1.LicensePlate}");
            sedan1.SpeedUp();
            sedan2.SpeedUp();
            truck1.SpeedUp();
        }
    }
}
