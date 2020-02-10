using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.showVehicle();
            child c = new child();
            c.showVehicle();
            c.show();
            Console.WriteLine("Single Inheritance");
            subchild s = new subchild();
            s.showVehicle();
            s.show();
            s.sub();
        }
    }
}
