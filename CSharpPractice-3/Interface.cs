using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_3
{
    public interface IParent {
        void show();
    }

    class derivedClass : IParent {
        public void show()
        {
            Console.WriteLine("inside show of interface");
        }
    }

}
