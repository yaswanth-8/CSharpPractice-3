using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_3
{
    public class Student
    {
        string name;
        private Marks mark;
        public Student(Marks mark)
        {
            this.mark = mark;
            Console.WriteLine(mark.science);
        }
    }
    public class Marks {
        
        public int science;
    }

}
