using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            Book book1 = new Book("Harry Potter","J.K. Rowling",400);

            Book book2 = new Book("Lord of the Rings","Tolkien",700);

            Console.WriteLine($"The author of {book1.title} is {book1.author} and it has {book1.pages} pages" );
            Console.WriteLine($"The author of {book2.title} is {book2.author} and it has {book2.pages} pages" );

            Console.ReadLine();
        }
    }
}