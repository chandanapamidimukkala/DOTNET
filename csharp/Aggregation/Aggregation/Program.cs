using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dp = new Department(1,"chandana");
            Employee e1 = new Employee(1, "Sai", dp);
            e1.display();
            Console.ReadKey();
        }
    }
}
