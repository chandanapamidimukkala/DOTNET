using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            calculate c = new calculate();
            Console.WriteLine(c.area(12));
            Console.WriteLine(c.area(10,20));
            Console.WriteLine(c.area(15.7));
            Console.WriteLine(c.area(112.6,10));
            Console.ReadKey();
        }
    }
}
