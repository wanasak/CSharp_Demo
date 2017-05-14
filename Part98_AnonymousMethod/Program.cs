using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Anonymous method is a method without name

namespace Part98_AnonymousMethod
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        //Step 1
        private static bool FindEmployee(Employee emp)
        {
            return emp.ID == 102;
        }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Mark"},
                new Employee{ ID = 102, Name = "John"},
                new Employee{ ID = 103, Name = "Mary"},
             };

            //Step 2
            Predicate<Employee> predicateEmploee = new Predicate<Employee>(FindEmployee);

            //Step 3
            Employee emp = employees.Find(e => predicateEmploee(e));
            Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}");

            // Anonymous method replace step 1, 2, 3
            emp = employees.Find(delegate (Employee e)
            {
                return e.ID == 102;
            });
            Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}");
        }
    }
}
