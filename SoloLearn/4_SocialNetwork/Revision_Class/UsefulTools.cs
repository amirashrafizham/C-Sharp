using System;

namespace Revision_Class
{
    class UsefulTools
    //Basically if you write as static class UsefulTools, it will behave similar to Math Class
    //You cant create an instance of this class
    {
        //when you add static to a method, it becomes the method of the class
        public static void sayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}