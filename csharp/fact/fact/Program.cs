using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Program
    {
        public static int Fact(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
                return n * Fact(n - 1);
             
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f = Fact(n);
            Console.WriteLine("factorial value of {0} is {1}", n, f);
            Console.ReadKey();
        }
    }
}
