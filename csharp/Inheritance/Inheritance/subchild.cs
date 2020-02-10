using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class subchild:child
    {
        public void sub()
        {
            Console.WriteLine("This is exmple of Multiple inheritance");
        }
        public override void show() //overiding the method
        {
            //base.show();
            Console.WriteLine("overrided method");
        }
    }
}
