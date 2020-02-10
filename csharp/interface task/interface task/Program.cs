using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_task
{
    class Program
    {
        static void Main(string[] args)
        {
            laiborne l;
            l = new Aeroplane();
            l.fly();
            l = new Helicopter();
            l.fly();
            Console.WriteLine();
        }
    }
}
