using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Employee
    {
        public int id;
        public string name;
        public Department d;//Employee HAS-A Department 
        public Employee(int id, string name, Department d)
        {
            this.id = id;
            this.name = name;
            this.d = d;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " +d.id + " " + d.dname);
        }
    }
}
