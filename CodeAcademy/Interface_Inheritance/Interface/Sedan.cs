
using System;

namespace Interface
{
    class Sedan : IAutomobile
    {
        public string LicensePlate { get; }
        public int Wheels { get; }
        public double Speed
        {
            get; private set;
        }
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public Sedan(double speed)
        {
            this.Speed = speed;
            this.LicensePlate = RandomPlateNumber();
            this.Wheels = 4;
        }

        public void SpeedUp()
        {
            this.Speed += 5;
        }
        public void SlowDown()
        {
            this.Speed -= 5;
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