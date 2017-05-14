using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part99_LambdaExpression
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


            // Anonymous method 
            Employee emp = employees.Find(delegate (Employee e)
            {
                return e.ID == 102;
            });
            Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}");

            // Lambda expression
            emp = employees.Find(e => e.ID == 102);
            Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}");
        }
    }
}
