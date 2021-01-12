using System;

namespace ActiveRecall
{
    class Student
    {
        public string name;
        public string course;
        public double marks;

        public Student(string aName, string aCourse, double aMarks)
        {
            name = aName;
            course = aCourse;
            marks = aMarks;
        }
        public string getMarks()
        {
            if (marks > 3.5)
            {
                return $"with honors";
            }
            else
            {
                return $"without honors";
            }
        }
    }
}