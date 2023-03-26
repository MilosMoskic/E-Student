using E_Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Student.Interfaces
{
    public interface IPrintStudents
    {
        public void ToString(List<Subject> students);
    }
}
