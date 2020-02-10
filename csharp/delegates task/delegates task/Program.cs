using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_task
{
    class Program
    {
        public delegate string del(int a);
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            del d = new del(area);
            Console.WriteLine(d(a));
        }
        static string area(int x)
        {
            int c = x * x;
            return string.Format("Area is {0}", c);
        }
    }
}
