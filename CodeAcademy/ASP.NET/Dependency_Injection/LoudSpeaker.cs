using System;

namespace Dependency_Injection
{
    public class LoudSpeaker : ISpeaker
    {
        public void Speak(string message)
        {
            Console.WriteLine(message.ToUpper() + "?");
        }
    }
}