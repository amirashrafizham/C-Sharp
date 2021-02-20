using System;

namespace Interface
{
    interface IAutomobile
    {
        string LicensePlate { get; }
        double Speed { get; }

        int Wheels { get; }

        void Honk();
    }
}