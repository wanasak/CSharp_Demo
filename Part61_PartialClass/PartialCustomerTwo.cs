using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part61_PartialClass
{
    public partial class PartialCustomer
    {
        public void GetFullName()
        {
            Console.WriteLine(_firstName + " " + _lastName);
        }
    }
}
