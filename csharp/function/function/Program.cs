using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class Program
    {
        public static int add(int a,int b)
        {
            int c = a + b;
            return c;
        }
        static void Main(string[] args)
        {
            int a,b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int c = add(a,b);
            Console.WriteLine("Add value of {0} and {1} is {2}",a ,b, c);
            Console.ReadKey();
        }
    }
}
