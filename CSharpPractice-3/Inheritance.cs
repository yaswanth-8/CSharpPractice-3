using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_3
{
    internal class Inheritance
    {
        public Inheritance() {
            Console.WriteLine("Inside Inheritance");
        }


        public class ClassLevel2 {
            public ClassLevel2()
            {
                Console.WriteLine("in level 2");
            }

            public class ClassLevel3
            {
                public ClassLevel3()
                {
                    Console.WriteLine("in level 3");
                }
            }
        }
        


    }
}
