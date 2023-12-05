using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOopBasedStudentData
{
    public class Student
    {
        string name, section;
        public string Name { get { return name; } set { name = value; } }
        public string Section { get { return section; } set { section = value; } }
        public Student(string name, string section)
        {
            this.Name = name;
            this.Section = section;
        }

    }
}
