using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class circle:shape
    {
        int r;
        public circle(int r)
        {
            this.r = r;
        }
        public override void area()
        {
            double b = Math.PI * r * r;
            Console.WriteLine("Area of cicle is {0}", b);
        }
    }
}
