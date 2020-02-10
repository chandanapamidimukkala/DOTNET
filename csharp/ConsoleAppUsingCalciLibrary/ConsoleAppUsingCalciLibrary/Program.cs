using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalciCalculation;

namespace ConsoleAppUsingCalciLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
            c1.No1 = 400;
            c1.No2 = 50;
            Console.WriteLine(c1.Add());
            Console.WriteLine(c1.Diff());
            Console.WriteLine(c1.Mul());
            Console.WriteLine(c1.Div());
            Console.ReadKey();
        }
    }
}
