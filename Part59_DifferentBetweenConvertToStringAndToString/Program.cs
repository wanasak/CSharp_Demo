using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ConvertToString() - Handles null
// ToString() - Does not handles null

namespace Part59_DifferentBetweenConvertToStringAndToString
{
    public class Customer
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = null;
            Console.WriteLine(customer.ToString()); // throw null exception
            //Console.WriteLine(Convert.ToString(customer));
        }
    }
}
