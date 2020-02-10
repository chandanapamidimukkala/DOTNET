using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //car mycar = new car();
            //car mycar1= new car("AP1066777");
            //car mycar2=new car("AP0753545", "Benz");
            car mycar3=new car("AP679999", "AUDI", "BLACK", 100000000);
            //mycar.showCar();
            //mycar1.showCar();
            //mycar2.showCar();
            string data=mycar3.showCar();
            Console.WriteLine(data);
        }
    }
}
