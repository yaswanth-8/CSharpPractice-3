﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_3
{
    class Car
    {
        public Car() {
            Console.WriteLine("Inside Car");
        }
        public virtual void wheels()
        {
            Console.WriteLine("normal wheels");
        }
    }
    class Audi:Car {
        public Audi()
        {
            Console.WriteLine("Audi");
        }
        public override void wheels()
        {
            Console.WriteLine("attached alloys");
        }

    }

}
