
using System;

namespace Interface
{
    class Truck : IAutomobile
    {
        public string LicensePlate { get; }
        public int Wheels
        {
            get;
            set;
        }
        public double Speed
        {
            get; private set;
        }
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public double Weight
        {
            get;
        }

        public Truck(double speed, double weight)
        {
            this.Speed = speed;
            this.Weight = weight;
            this.LicensePlate = RandomPlateNumber();

            if (this.Weight <= 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public void SpeedUp()
        {
            Speed += 5;
        }
        public void SlowDown()
        {
            Speed -= 5;
        }


        private string RandomPlateNumber()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();
            string plateNumber;
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            plateNumber = String.Join("", stringChars);
            return plateNumber;

        }
    }
}