﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_MO_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer
            {
                CID = 844834,
                Name = "Chandana",
                Address = "Chennai",
                b = new Bank { Accno = 8767566554 },
            };
            Console.WriteLine("{0}\t{1}\t{2}", c.CID, c.Name, c.Address);
            Console.WriteLine("{0}",c.b.Accno);
            Console.WriteLine("{0}", c.interestamt(24000));
            Bank bk = new Bank();
            Console.WriteLine("{0}", bk.interestamt(24000));
        }
    }
}
