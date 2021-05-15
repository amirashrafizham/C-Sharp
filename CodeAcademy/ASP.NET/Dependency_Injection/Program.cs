using System;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using trainer: ");
            Trainer trainer = new Trainer(new QuietSpeaker());
            trainer.BeginTraining();
        }
    }
}


/*
1. In this exercise, the Trainer class depended on the LoudSpeaker class.
2. However, when we made changes to the LoudSpeaker class' method i.e from Amplify() -> Speak(), we had to change in the Trainer class as well 
3. Moreover both, LoudSpeaker and QuietSpeaker classes had a Speak() method. In order for the Trainer class to implement QuietSpeaker, we had to change in the Trainer class again as well
4. We don't want to make any changes in the Trainer class, because it is a higher module. We should make changes in the LoudSpeaker and QuietSpeaker classses i.e. lower module
5. To resolve this, we must implement an interface to the lower modules.
6. Then we create a constructor in the higher module class that accepts an interface argument i.e. Trainer(ISpeaker speaker) 
7. In the program class, during instantiation of the higher module, instantiate the lower module of choice i.e. [STEPS 1-6 are part of Dependency Inversion Principle]
    Trainer trainer = new Trainer(new LoudSpeaker())
                    OR
    Trainer trainer = new Trainer(new QuietSpeaker())
8. However, in ASP.NET you don't have to do step number 7. It is done automatically using ASP.NET's IoC Container in the ConfigureServices() [STEP 8 is part of Inversion of Control]
    services.AddScoped<ISpeaker,LoudSpeaker>()
9. There are 3 types of services:
    services.AddScoped
    services.AddTransient
    services.AddSingleton

*/