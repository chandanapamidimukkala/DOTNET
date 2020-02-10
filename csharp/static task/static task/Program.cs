using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_task
{
    class Program
    {
        static void Main(string[] args)
        {
            sales s = new sales();
            s.Productname = "Cake";
            s.Quantity = 3;
            s.Price = 125;
            Console.WriteLine(s.Saleamount);
            Console.WriteLine(s.Totalamount);
            sales s1 = new sales();
            s1.Productname = "Chocolate";
            s1.Quantity = 7;
            s1.Price = 200;
            Console.WriteLine(s1.Saleamount);
            Console.WriteLine(s1.Totalamount);
            Console.ReadKey();
        }
    }
}
