using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_MO_Task
{
    class Customer
    {
        int cid;
        string name, address;
        public int CID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Bank b { get; set; }
        public virtual string interestamt(double interest)
        {
            return interest.ToString();
        }
    }
}
