using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threads
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 13, 4, 6, 8, 12, 5, 4, 17, 10 };
            var q=from  s in a
                where s%2 is 0
                select s;
            foreach(var x in q)
            {
                Console.WriteLine(x);
            }
        }
       
    }
}
