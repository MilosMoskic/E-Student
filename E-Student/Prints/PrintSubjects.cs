using E_Student.Data;
using E_Student.Interfaces;
using E_Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Student.Prints
{
    public class PrintSubjects : IPrintSubjects
    {
        public void ToString()
        {
            foreach(var item in Database.Subjects)
            {
                Console.WriteLine($"{item.Name}");
            }

        }
        public Subject GetSubjectById(int id)
        {
            return Database.Subjects.FirstOrDefault(x => x.Id == id);
        }
    }
}
