using E_Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Student.Data
{
    public static class Database
    {
        public static Dictionary<double, string> gradeName = new Dictionary<double, string>()
        {
            {1, "F" },
            {2, "D" },
            {3, "C" },
            {4, "B" },
            {5, "A" }

        };
        public static List<Subject> Subjects = new List<Subject>
        {
            new Subject(1, "Mathematics"),
            new Subject(2, "English"),
            new Subject(3, "History"),
            new Subject(4, "Geography"),
            new Subject(5, "PE"),
            new Subject(6, "Chemistry"),
            new Subject(7, "Physics"),
            new Subject(8, "Informatics")
        };
        public static List<Student> Students = new List<Student>();
        public static List<Grade> Grades = new List<Grade>();
    }
}
