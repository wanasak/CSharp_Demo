using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part61_PartialClass
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer
            {
                Firstname = "John",
                Lasttname = "Papa"
            };
            c1.GetFullName();

            PartialCustomer c2 = new PartialCustomer
            {
                Firstname = "Dan",
                Lasttname = "Wahlin"
            };
            c2.GetFullName();
        }
    }
}
