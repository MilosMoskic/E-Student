using E_Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Student.Services
{
    public class StudentInput
    {
        StudentServices studentServices = new StudentServices();
        public StudentInput(StudentServices studentServices)
        {
            this.studentServices = studentServices;
        }

        public void StudentInputt()
        {
            Console.WriteLine("Enter students Firstname and Lastname (Add \",\" between if adding multiple)");
            string enteredStudent = Console.ReadLine();
            string[] studentParsed;
            List<Student> students = new List<Student>();

            if (!enteredStudent.Contains(", "))
            {
                studentParsed = enteredStudent.Split(" ");
                students.Add(new(studentParsed[0], studentParsed[1]));
            }
            else
            {
                studentParsed = enteredStudent.Split(',');
                foreach (var item in studentParsed)
                {
                    var trimmedItem = item.Trim();
                    string[] splitStudentInfo = trimmedItem.Split(" ");


                    Student studentMapped = new(splitStudentInfo[0], splitStudentInfo[1]);
                    students.Add(studentMapped);
                }
            }

            studentServices.AddStudents(students);

        }
    }
}
