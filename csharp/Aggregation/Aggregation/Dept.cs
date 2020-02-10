using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    public class Department
    {
        public int id;
        public string dname;
        public Department(int id,string dname)
        {
            this.id = id;
            this.dname = dname;
        }
    }
}
