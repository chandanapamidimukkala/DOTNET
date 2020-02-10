using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> l = new List<Employee>();
            l.Add(new Employee { Eid = 549, Ename = "swathi", designation = "pat", salary = 5456 });

            l.Add(new Employee { Eid = 567, Ename = "rams", designation = "pat", salary = 6478658 });
            l.Add(new Employee { Eid = 540, Ename = "prass", designation = "pat", salary = 700000 });
            foreach (Employee e in l)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.Eid, e.Ename, e.designation, e.salary);
            }
            Console.WriteLine("after removing the element");
            l.RemoveAt(2);
            foreach (Employee e in l)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.Eid, e.Ename, e.designation, e.salary);
            }

            Console.ReadKey();

        }
    }
}
