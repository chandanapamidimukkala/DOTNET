using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam e = new Exam();
            e.getData("Sai", 67, "Maths", 90);
            e.showData();
            Console.ReadKey();
        }
    }
}
