using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        public delegate string Mydel(int x, int y);
        static void Main(string[] args)
        {
            Mydel delg = new Mydel(Add
                );
            Console.WriteLine(delg(12, 30));
            delg += new Mydel(Subtract);
            Console.WriteLine(delg(12, 25));
            delg -= new Mydel(Subtract);
            Console.WriteLine(delg(20, 50));
            delg -= new Mydel(Mul);
            Console.WriteLine(delg(20, 5));
        }
        static string Add(int a,int b)
        {
            int c = a + b;
            return string.Format("{0}+{1}={2}", a, b, c);
        }
        static string Subtract(int a, int b)
        {
            int c = a - b;
            return string.Format("{0}-{1}={2}", a, b, c);
        }
        static string Mul(int a, int b)
        {
            int c = a * b;
            return string.Format("{0}*{1}={2}", a, b, c);
        }

    }
}
