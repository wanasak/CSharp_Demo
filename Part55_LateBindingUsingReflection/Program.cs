using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Part55_LateBindingUsingReflection
{
    public class Customer
    {
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Late binding - Use late binding only when working with an objects that are not available at compile time
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("Part55_LateBindingUsingReflection.Customer");
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");
            string[] parameters = new string[2];
            parameters[0] = "John";
            parameters[1] = "Liquid";

            // Invoke method
            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

            Console.WriteLine("Full Name = {0}", fullName);
        }
    }
}
