using System;

namespace Inheritance
{
    abstract class Vehicle
    {

        public string LicensePlate { get; protected set; }
        public double Speed { get; protected set; }
        public int Wheels { get; protected set; }
        virtual public void SpeedUp()
        {
            Speed += 5;
        }
        virtual public void SlowDown()
        {
            Speed -= 5;
        }

        public Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = LicenseGenerator();
        }

        abstract public string Describe();

        private string LicenseGenerator()
        {
            string threeLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string fourNumbers = "123456789";
            var rand = new Random();
            char[] plateArray = new char[7]; //The length of License Plate number

            for (int i = 0; i <= 2; i++)
            {
                var j = rand.Next(threeLetters.Length);
                plateArray[i] = threeLetters[j];
            }
            for (int i = 3; i <= 6; i++)
            {
                var j = rand.Next(fourNumbers.Length);
                plateArray[i] = fourNumbers[j];
            }
            string finalPlate = new string(plateArray);

            return finalPlate;
        }
    }
}
