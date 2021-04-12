using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1975);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = new Rover[] { lunokhod, apollo, sojourner };

            Object[] probesList = new object[] { lunokhod, apollo, sojourner, sputnik };
            IDirectable[] directProbes = new IDirectable[] { lunokhod, apollo, sojourner, sputnik };

            foreach (Object item in probesList)
            {
                Console.WriteLine($"Tracking a : {item.GetType()}");
            }

            Console.WriteLine("*************************************************\n");



            DirectAll(rovers);
        }

        static void DirectAll(IDirectable[] arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                Console.WriteLine(arg[i].GetInfo());
                Console.WriteLine(arg[i].Explore());
                Console.WriteLine(arg[i].Collect());
                Console.WriteLine("\n");
            }
        }
    }
}
