using E_Student.Models;
using E_Student.Prints;
using E_Student.Services;

public class Program
{
    public static void Main(string[] args)
    {
        PrintSubjects printSubjects = new PrintSubjects();
        StudentServices studentServices = new StudentServices();
        StudentInput studentInput = new StudentInput(studentServices);
        Grades grades = new Grades(studentServices);
        GradeServices gradeServices = new GradeServices(studentServices, printSubjects, grades);

        bool terminate = true;

        Console.WriteLine("1. Print all subjects.\r\n" +
                          "2. Insert new students\r\n" +
                          "3. Insert grade for certain student and certain subject.\r\n" +
                          "4. Print all grades for all subjects for certain student and current average grade.\r\n" +
                          "5. EXIT\n");

        while (terminate)
        {
            string userInput = Console.ReadLine();
            
            switch(userInput)
            {
                case "1":
                    printSubjects.ToString();
                    break;
                case "2":
                    studentInput.StudentInputt();
                    break;
                case "3":
                    studentServices.GetAllStudents();
                    gradeServices.GradeStudent();
                    break;
                case "4":
                    studentServices.GetAllStudents();
                    Console.WriteLine("Enter students ID:");
                    int.TryParse(Console.ReadLine(), out int studentId);
                    grades.GetGradesByStudentId(studentId);
                    break;
                case "5":
                    terminate = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }
}