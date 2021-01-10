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

            Movie movie1 = new Movie("The Avengers","Joss Whedon","PG-13");
            Movie movie2 = new Movie("Shrek","Adam Adamson","PG");

            Song song1 = new Song ("Holiday","Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song song2 = new Song ("Kashmir","Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            Console.ReadLine();

        }
    }
}
