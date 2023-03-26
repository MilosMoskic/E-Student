﻿using E_Student.Data;
using E_Student.Models;
using E_Student.Prints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Student.Services
{
    public class GradeServices
    {
        StudentServices studentServices;
        PrintSubjects printSubjects;
        Grades gradeServices;
        public GradeServices(StudentServices studentServices, PrintSubjects printSubjects, Grades gradeServices)
        {
            this.studentServices = studentServices;
            this.printSubjects = printSubjects;
            this.gradeServices = gradeServices;
        }
        public void GradeStudent()
        {

            Console.WriteLine("Which student do you want to grade? (StudentID) ");
            var studentId = int.Parse(Console.ReadLine());

            var student = studentServices.GetStudent(studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            Console.WriteLine("Which subject? Enter subject ID ");
            var subjectId = int.Parse(Console.ReadLine());

            var subject = printSubjects.GetSubjectById(subjectId);

            if (subject == null)
            {
                Console.WriteLine("Subject not found");
                return;
            }

            Console.WriteLine($"Subject: {subject.Name}, Student {student.FirstName} {student.LastName} \n Enter grade: (1-5)");
            if (!int.TryParse(Console.ReadLine(), out int grade))
            {
                Console.WriteLine("Grade can only be whole number.");
                return;
            }

            if (grade >= 1 && grade <= 5)
            {
                gradeServices.AddGrade(student, subject, grade);
                Console.WriteLine("Succesfully graded.");
                return;
            }
            else
            {
                Console.WriteLine("Grade must be between 1 and 5.");
                return;
            }
        }
    }
}
