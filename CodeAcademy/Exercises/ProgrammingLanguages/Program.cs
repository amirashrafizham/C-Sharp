using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Language> languages = File.ReadAllLines("C:/Users/amirashraf.ahmadizh/OneDrive - PETRONAS/Desktop/C-Sharp/CodeAcademy/Exercises/ProgrammingLanguages/languages.tsv")
                .Skip(1)
                .Select(line => Language.FromTsv(line))
                .ToList();
            //languages is a List

            //EXPLORE THE DATA SECTION
            /*
                        foreach (var item in languages)
                        {
                            Console.WriteLine(item.Prettify());
                        }
            */

            var pLang = from h in languages
                        select $"{h.Name} was built in {h.Year} by {h.ChiefDeveloper}";



            //MICROSOFT LANGUAGES SECTION
            var cSharp = from h in languages
                         where h.Name == "C#"
                         select h;

            var microsoft = from h in languages
                            where h.ChiefDeveloper.Contains("Microsoft")
                            select h;


            //GOOD PROGRAMMERS COPY SECTION
            var lispList = from h in languages
                           where h.Predecessors.Contains("Lisp")
                           select h;

            Console.Write("\n");
            var scriptsList = from h in languages
                              where h.Name.Contains("Script")
                              select h;


            //Y2K SECTION
            Console.WriteLine(languages.Count); //total languages between 1990s and 2000s

            var released = from h in languages
                           where h.Year >= 1995 && h.Year <= 2005
                           select h; // total languages between 1994 and 2005 (near millenium)
            Console.WriteLine(released.Count());

            var releasedString = from h in languages
                                 where h.Year >= 1995 && h.Year <= 2005
                                 select $"{h.Name} was invented in {h.Year}"; // languages between 1994 and 2005 (near millenium) and its built year

            //PRINT METHODS SECTION
            //refer to static void

            PrettyPrintAll(released); //you can input all of the linq queries you have created in the previous sections as your argument, AND it will return Prettify() method

            PrintAll(scriptsList); //you can input all of the linq queries you have created in the previous sections as your argument, AND it will return SELECT that you specified

        }

        static void PrettyPrintAll(IEnumerable<Language> arg)
        {
            foreach (var item in arg)
            {
                Console.WriteLine($"{item.Prettify()}");
            }
        }

        static void PrintAll(IEnumerable<Object> arg)
        {
            foreach (Object item in arg)
            {
                Console.WriteLine(item);
            }
        }
    }
}
