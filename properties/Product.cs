using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    public class Product
    {
        private int price, pcode;
        private string pname;

        // property syntax --> access specifier property(return) type property name
        public string Name
        {
            set { pname = value; }   // value is a built in keyword which assign the value
            get { return pname; }
        }

        public int Price
        {
            set { price = value; }
            get { return price; }
        }

        public int Pcode
        {
            set { pcode = value; }
            get { return pcode; }
        }

        // to display product.. will write method
        public string Printp()
        {
            return $"the name of product {pname} price {price} product code {pcode}";
        }
    }
}
