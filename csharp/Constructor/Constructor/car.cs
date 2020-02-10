using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class car
    {
        string regno, model, color;
        double price;
        public car()//default constructor
        { }
        public car(string reg)//overloaded
        {
            regno = reg;
        }
        public car(string reg,string mod)
        {
            regno = reg;
            model = mod;
        }
        public car(string reg,string mod,string colr,double pr)
        {
            regno = reg;
            model = mod;
            color = colr;
            price = pr;
        }
        /*public void showCar()
        {
            Console.WriteLine("Reg no is" + regno);
            Console.WriteLine("Model is" + model);
            Console.WriteLine("color is {0} and price is {1}", color, price);
        }*/
        public string showCar()
        {
            return string.Format("Reg no:{0}\nModel:{1}\ncolour:{2}\nPrice:{3}", regno, model, color, price);
        }
    }
}
