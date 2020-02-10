using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.add(10,2));
            Console.WriteLine("Sub is {0}", c.diff(20,5));
            Console.WriteLine("Div is {0}", c.div(20,5));
            Console.WriteLine("Mul is {0}", c.mul(10,20));
        }
    }
}
