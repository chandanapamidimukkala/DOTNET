using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class child:parent
    {
        public virtual void show()
        {
            Console.WriteLine("Derived class");
        }
    }
}
