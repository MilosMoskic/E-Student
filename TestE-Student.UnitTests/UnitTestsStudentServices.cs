using E_Student.Models;
using E_Student.Services;
using NUnit.Framework;
using System.Collections.Generic;
using Assert = NUnit.Framework.Assert;

namespace TestE_Student.UnitTests
{
    [TestClass]
    public class UnitTestsStudentServices
    {
        [TestMethod]
        public void AddStudentsToDatabase_FirstAndLastName_DoNotExist()
        {
            //Arrange
            var studentService = new StudentServices();
            var student = new Student("Milos", "Moskic");
            List<Student> students = new List<Student>();
            students.Add(student);

            //Act
            studentService.AddStudents(students);

            //Assert
            Assert.IsNotNull(students.Any());
        }
        [TestMethod]

        public void AddStudentsToDatabase_FirstAndLastName_DoExisting()
        {
            //Arrange
            var studentService = new StudentServices();
            List<Student> students = new List<Student>()
            {
                new Student("Milos", "Moskic")
            };

            var student = new Student("Milos", "Moskic");
            List<Student> addedStudent = new List<Student>();
            addedStudent.Add(student);

            //Act
            studentService.AddStudents(addedStudent);

            //Assert
            Assert.IsNotNull(students.Contains(student));
        }

        [TestMethod]

        public void GetStudent_HasRecords()
        {
            //Arrange
            var studentService = new StudentServices();
            List<Student> students = new List<Student>()
            {
                new Student("Milos", "Moskic")
            };

            //Act
            var result = studentService.GetStudent(students[0].Id);

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetStudent_DoesNotHaveRecords()
        {
            //Arrange
            var studentService = new StudentServices();
            List<Student> students = new List<Student>();

            //Act
            bool isNullOrEmpty = students?.Any() != true;

            //Assert
            Assert.IsEmpty(students);
        }
    }
}