using System;
using System.Collections.Generic;

namespace Part37_DelegateUsage
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

		//public static void PromotionEmployee(List<Employee> emplyees)
		//{
		//    foreach (Employee e in emplyees)
		//    {
		//        if (e.Experience >= 5) 
		//            Console.WriteLine($"Promote: {e.Name}");
		//    }
		//}
        public static void PromotionEmployee(List<Employee> emplyees, IsPromotable isPromotable)
		{
			foreach (Employee e in emplyees)
			{
                if (isPromotable(e))
					Console.WriteLine($"Promote: {e.Name}");
			}
		}
    }

    delegate bool IsPromotable(Employee e);

    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
				new Employee(){ ID = 1, Name = "John", Salary = 10000, Experience = 4 },
				new Employee(){ ID = 2, Name = "Rick", Salary = 20000, Experience = 5 },
				new Employee(){ ID = 3, Name = "Cory", Salary = 10000, Experience = 6 },
				new Employee(){ ID = 4, Name = "Dan", Salary = 20000, Experience = 7 } 
            };

            IsPromotable ip = new IsPromotable(Promote);

            //Employee.PromotionEmployee(employees);
            //Employee.PromotionEmployee(employees, ip);
            // lamda expression
            Employee.PromotionEmployee(employees, emp => emp.Experience >= 5);
        }

        public static bool Promote(Employee emp)
        {
            return (emp.Experience >= 5);
        }
    }
}
