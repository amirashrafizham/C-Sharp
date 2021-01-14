using System;
using System.Linq;
namespace ActiveRecall
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book2 = new Book("Models", "Mark Manson", 300);
            Book book3 = new Book("How to Win Friends and Influence People", "Dale Carnegie", 150);

            Student student1 = new Student("Amir", "Mechanical Engineering", 3.5);
            Student student2 = new Student("Ashraf", "Software Engineering", 3.3);

            Movie movie1 = new Movie("Avengers", "Amir", "PG-13"); 
            Movie movie2 = new Movie("LOTR", "Ashraf", "18-SX"); 
            Console.ReadLine();
        }
    }
}