using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            shape c = new circle(9);
            c.area();
            Console.ReadKey();
        }
    }
}
