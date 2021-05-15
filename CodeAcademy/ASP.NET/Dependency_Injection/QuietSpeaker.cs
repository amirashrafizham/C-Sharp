using System;

namespace Dependency_Injection
{
    public class QuietSpeaker : ISpeaker
    {
        public void Speak(string message)
        {
            Console.WriteLine("..." + message.ToLower() + "...");
        }
    }
}