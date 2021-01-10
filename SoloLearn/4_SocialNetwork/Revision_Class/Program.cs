using System;

namespace Revision_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "J.K.Rowling",400);
            Book book2 = new Book("Lord of the Rings","J.R.R Tolkien", 500);

            Student student1 = new Student("Amir","Mechanical Engineering",3.5);
            Student student2 = new Student("Ashraf","Software Engineering",3.0);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.ReadLine();

        }
    }
}
