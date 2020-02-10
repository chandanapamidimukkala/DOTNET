using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //tomato t = new tomato();
            veg ve;
            vegetables v;
            v = new tomato();
            ve = new tomato();
            v.color();
            v.Type();
            ve.shape();
            v = new potato();
            v.color();
            v.Type();
            Console.ReadKey();
        }
    }
}
