using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Automatic_properties ap = new Automatic_properties { Id = 1, Pname = "Choolate", Price = 100 };
            Console.WriteLine("{0}\n{1}\n{2}", ap.Id, ap.Pname, ap.Price);
        }
    }
}
