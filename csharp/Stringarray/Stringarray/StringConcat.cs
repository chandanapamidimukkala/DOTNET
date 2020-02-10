using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringarray
{
    class StringConcat
    {
        public void data(string firstname,string lastname)
        {
            Console.WriteLine("String Conacatination:{0}",String.Concat(firstname, lastname));
        }
    }
}
