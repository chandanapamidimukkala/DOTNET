using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_task
{
    class sales
    {
        string productname;
        int quantity;
        double price;
        double saleamount;
        static double totalamount = 0;
        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double Saleamount
        {
            get { return price * quantity; }
        }
        public double Totalamount
        {
            get { return totalamount += Saleamount; }
        }
    }
}
