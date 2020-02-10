using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuetype
{
    class Program
    {
        static void Value(int x,int y)
        {
            x = 5;
            y = 10;
            Console.WriteLine("{0} & {1}", x, y);
        }
        static void Ref(ref int a,ref int b)
        {
            a =32;
            b = 24;
            Console.WriteLine("{0} & {1}", a, b);
        }
        static void Main(string[] args)
        {
            int x= 9, y= 12, a= 28, b= 38;
            Console.WriteLine("{0},{1},{2},{3}",x,y,a, b);
            Value(x,y);
            Console.WriteLine("{0},{1}", x, y);
            Ref(ref a,ref b);
            Console.WriteLine("{0},{1}", a, b);
            Console.ReadKey();
        } 
    }
}



