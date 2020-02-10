using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Calculator
    {
        int a, b;
        public void calc()
        { }
        public void calc(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public int add(int a,int b)
        {
            return  a + b;
        }
        public int diff(int a, int b)
        {
            return  a - b;
        }
        public int mul (int a, int b)
        {
            return  a * b;
        }
        public int div(int a, int b)
        {
            return  a/b;
        }
        /*public void showData()
        {
            Console.WriteLine("Add is" + c);
            Console.WriteLine("Sub is" + d);
            Console.WriteLine("Mul is" + e);
            Console.WriteLine("Div is" + f);
        }*/
    }
}
