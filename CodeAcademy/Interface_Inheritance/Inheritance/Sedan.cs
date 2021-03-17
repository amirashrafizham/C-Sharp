
using System;

namespace Inheritance
{
    class Sedan : Vehicle, IAutomobile
    {

        public Sedan(double speed) : base(speed)
        {
            Wheels = 4;
        }
        public override string Describe()
        {
            return $"This car is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }


    }
}