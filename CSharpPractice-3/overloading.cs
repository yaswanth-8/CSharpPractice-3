using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_3
{
    internal class overloading
    {
        public void display(string name, int id=8)
        {
            Console.WriteLine(name+id);
        }
        public overloading() {
            display("yaswanth",88);
        }
    }
}
