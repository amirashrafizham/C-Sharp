
using System;

namespace Inheritance
{
    class Truck : Vehicle, IAutomobile
    {
        double Weight { get; set; }
        public Truck(double speed, double weight) : base(speed)
        {
            Weight = weight;
            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }

        }

        public override string Describe()
        {
            return $"This truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }
    }
}