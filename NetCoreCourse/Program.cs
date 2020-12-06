using System;

namespace NetCoreCourse
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "J.K. Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkien";
            book2.pages = 700;
            Console.WriteLine($"The author of {book1.title} is {book1.author} and it has {book1.pages} pages" );
            Console.WriteLine($"The author of {book2.title} is {book2.author} and it has {book2.pages} pages" );

            Console.ReadLine();
        }
    }
}