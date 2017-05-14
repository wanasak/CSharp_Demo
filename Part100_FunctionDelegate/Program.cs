using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Function delegate is just a generic delegate
// Function delegate is the same as lambda expression

namespace Part100_FunctionDelegate
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
             {
                 new Employee{ ID = 101, Name = "Mark"},
                 new Employee{ ID = 102, Name = "John"},
                 new Employee{ ID = 103, Name = "Mary"},
             };

            // Function delegate
            Func<Employee, string> funcEmployee = emp => "Name =" + emp.Name;
            IEnumerable<string> names = employees.Select(funcEmployee);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Func<int, int, string> funcNumber = (number1, number2) => "Sum = " + (number1 + number2).ToString();
            string result = funcNumber(10, 20);
            Console.WriteLine(result);
        }
    }
}
