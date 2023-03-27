using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_3
{
    abstract class AbstractClass
    {
        public string name;
        public AbstractClass(string name)
        {
            Console.WriteLine(name + " in constructor");
        }
        abstract public void method(string name);
    }
    class Derived: AbstractClass { 
        public Derived () : base("yaswanth")
        {

        }
        public override void method(string name)
        {
            Console.WriteLine("name in derived" + name);
        }
    }
}
