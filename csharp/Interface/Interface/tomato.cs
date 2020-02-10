using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class tomato:vegetables,veg
    {
        public void color()
        {
            Console.WriteLine("Tomato is in red  color");
        }
        public void Type()
        {
            Console.WriteLine("It is juicy");
        }
        public void shape()
        {
            Console.WriteLine("Tomato is Round");
        }
    }
}
