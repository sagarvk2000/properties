using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    public class employee
    {
        private int id,empsal;
        private string city, empname;

        public employee(string empname, int id, int empsal, string city = "pune")
        {         
            this.empname = empname;          
            this.id = id; 
            this.empsal = empsal;
            this.city = city;
        }

       public string Empd()
        {
           return $"name is{empname}/id {id}/salary{empsal}/city{city}";
        }

    }
}
