using E_Student.Data;
using E_Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Student.Services
{
    public class Grades
    {
        StudentServices studentServices;

        public Grades(StudentServices studentServices)
        {
            this.studentServices = studentServices;
        }

        public bool AddGrade(Student student, Subject subject, int grade)
        {
            Grade gradetoAdd = new Grade()
            {
                Student = student,
                Subject = subject,
                GradeValue = grade
            };
            Database.Grades.Add(gradetoAdd);

            return true;
        }
        public void GetAllGrades()
        {
            foreach (var grade in Database.Grades)
            {
                Console.WriteLine($"Student: {grade.Student.FirstName} {grade.Student.LastName}, Predmet: {grade.Subject.Name}, Ocena({grade.GradeValue})");
            }
        }

        public void GetGradesByStudentId(int studentId)
        {
            var result = new List<Grade>();
            var student = studentServices.GetStudent(studentId);

            if (student == null)
            {
                Console.WriteLine("Student does not exist");
                return;
            }

            Console.WriteLine($"Showing all grades for student: {student.FirstName} {student.LastName}");
            var subjects = Database.Subjects;
            foreach (var subject in subjects)
            {
                var studentGrades = Database.Grades.Where(g => g.Subject == subject).ToList();
                if (studentGrades.Count > 0)
                {
                    var average = Math.Round(studentGrades.Average(g => g.GradeValue), 2);
                    var averageRounded = Math.Round(average, 0);
                    string averageText = Database.gradeName[averageRounded];

                    Console.Write($"{subject.Name} Grades[");
                    foreach (var grade in studentGrades)
                    {
                        Console.Write($"{grade.GradeValue}, ");
                    }
                    Console.WriteLine($"] Average: {average} - {averageText}");
                }

                else
                {
                    Console.WriteLine($"Student has no grades in {subject.Name}");
                }
            }

        }
    }
}
