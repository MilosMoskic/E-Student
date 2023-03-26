using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Student.Models
{
    public class Grade
    {
        public int GradeValue { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
