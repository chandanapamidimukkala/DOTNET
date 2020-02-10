using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringarray
{
    class Stringsplit
    {
        public void display()
        {
            string str = "Prasanna Lakshmi Borra";
            string[] arr= str.Split();
            foreach (string s in arr)
            {
                Console.WriteLine("{0}",s);
            }
        }
    }
}
