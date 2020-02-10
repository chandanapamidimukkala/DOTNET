using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringarray
{
    class Program
    {
        static void Main(string[] args)
        {
            StringArr sa = new StringArr();
            string[] s1 = {"Prasanna","is","a","good","girl"};
            sa.show(s1);
            StringConcat sc = new StringConcat();
            sc.data("Prasanna", "Lakshmi");
            Stringsplit ss = new Stringsplit();
            ss.display();
            Console.ReadKey();
        }
    }
}
