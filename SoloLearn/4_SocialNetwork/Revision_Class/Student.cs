using System;
namespace Revision_Class
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;
        public string grad;
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public string HasHonors()
        {
            if (gpa >= 3.5)
            {
                return grad = $"{name} graduated in {major} with honors";
            }
            else
            {
                return grad = $"{name} graduated in {major} without honors";
            }
        }
    }
}