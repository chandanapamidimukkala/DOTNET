﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_MO_Task
{
    class Bank:Customer
    {
        double accno;
        public double Accno { get; set; }
        public override string interestamt(double bal)
        {
            double si = 0.03 * bal;
            double totalbal = bal + si;
            return totalbal.ToString();
        }
    }
}
