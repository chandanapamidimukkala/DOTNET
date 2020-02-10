using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    class Trainee
    {
        //data fields
        private string name, id, address;//instance var iable
        private int age;
        public void GetData(string nm,string id,string adr,int ag)
        {
            name = nm;
            this.id = id;//this is used as instance variable when instance variable and local variable are same
            address = adr;
            age = ag;
        }
        public void showData()
        {
            Console.WriteLine(name);
            Console.WriteLine(id + " " + address);
            Console.WriteLine(age);
        }
    }
}
