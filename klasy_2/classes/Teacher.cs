using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_2.classes
{
    internal class Teacher
    {
        public List<string>? Subjects;
        public void GetSubjects()
        {
            Console.WriteLine(string.Join(", ", Subjects));
        }
    }
}
