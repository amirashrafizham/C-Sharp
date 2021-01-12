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
            Console.WriteLine($"{student1.name} graduated in {student1.course} with a CGPA of {student1.marks} {student1.getMarks()}");
            Console.WriteLine($"{student2.name} graduated in {student2.course} with a CGPA of {student2.marks} {student2.getMarks()}");
            Console.ReadLine();
        }
    }
}