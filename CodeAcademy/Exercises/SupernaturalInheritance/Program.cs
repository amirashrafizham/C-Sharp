using System;

namespace SupernaturalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm c1 = new Storm("Wind", false, "Zul' Rajas");

            Pupil p1 = new Pupil("Mezil-kree");
            Storm p11 = p1.CastWindStorm();
            Console.WriteLine(p11.Announce());

            Mage m1 = new Mage("Gul'dan");
            Storm m11 = m1.CastRainStorm();
            Console.WriteLine(m11.Announce());

            Archmage a1 = new Archmage("Nielas Aran");
            Storm aa1 = a1.CastLightningStorm();
            Console.WriteLine(aa1.Announce());

        }
    }
}
