
using System;

namespace AppInterfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            if (!Hidden)
            {
                Console.WriteLine(Hidden);
            }
            else
            {
                Console.WriteLine("*");
            }
        }

        public void Reset()
        {
            Password = String.Empty;
            Hidden = false;
        }

    }
}
