using System;

namespace Inheritance
{
    class Bicycle : Vehicle, IAutomobile
    {
        public Bicycle(double speed) : base(speed)
        {
            Wheels = 2;
            if (Speed > 15)
            {
                Speed = 15;
            }
            else if (Speed < 0)
            {
                Speed = 0;
            }
        }

        override public void SpeedUp()
        {
            Speed += 5;
            if (Speed > 15)
            {
                Speed = 15;
            }
        }

        override public void SlowDown()
        {
            Speed -= 5;
            if (Speed < 0)
            {
                Speed = 0;
            }
        }

        public override string Describe()
        {
            return $"This bicycle is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }
    }
}