using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // property initializer syntax
            //Product product1 = new Product();
            //product1.Name = "Mobile";  // call to set accessor
            //product1.Price = 200;
            //product1.Pcode = 90;

            // get accessor
            //product1.Pcode = 6116; Console.WriteLine($"name is {product1.Name} " +
            //    $"price {product1.Price} code is {product1.Pcode}");

            // object initializer syntax
            // Product product2 = new Product {Name = "laptop",Price = 300,Pcode =656};
            //product product2 = new product () {Name = "laptop",Price = 300,Pcode =656};
            //Console.WriteLine($"name is {product2.Name} price {product2.Price} code is {product2.Pcode}");



            employee employee1 = new employee("sagar",24,3000);//default intialized parameter in employee class

            Console.WriteLine(employee1.Empd());


            employee employee2 = new employee("sagar", 24, 3000,"solapur"); //override

            Console.WriteLine(employee2.Empd());

            //named argument
            employee employee3 = new employee(empname :"sagar", id :24, empsal :3000,city :"mumbai");
            
            Console.WriteLine(employee3.Empd());




        }
    }
}
