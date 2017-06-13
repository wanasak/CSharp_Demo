using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part53_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Early binding
            Customer c1 = new Customer();

            // Late binding
            //Type type = Type.GetType("Part53_Reflection.Customer");
            Type type = typeof(Customer);
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
            }
            var methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
        }
    }
}
