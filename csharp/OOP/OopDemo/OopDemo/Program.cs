using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //object of Trainee class
            getObj();

            Trainee tr1 = new Trainee();
            tr1.GetData("charan", "EMP800844", "Chennai", 19);
            tr1.showData();
            Console.ReadKey();
        }

        private static void getObj()
        {
            Trainee tr = new Trainee();
            tr.GetData("chandana", "EMP844844", "Chennai", 21);
            tr.showData();
        }
    }
}
