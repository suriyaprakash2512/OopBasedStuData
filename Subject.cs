using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOopBasedStudentData
{
    public class Subject
    {
        public string SubName { get; set; }
        public int SubCode { get; set; }
        public string Teacher { get; set; }
        public Subject(string name, int code, string teacher)
        {
            SubName = name;
            SubCode = code;
            Teacher = teacher;
        }

    }
}
