using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringarray
{
    class StringArr
    {
        public void show(string[] array)
        {
            string s1 = string.Join(",", array);
            Console.WriteLine("String Array:{0}",s1);
        }
    }
}
