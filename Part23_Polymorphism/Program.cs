using System;

namespace Part23_Polymorphism
{
    class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName} (Full Time)");
        }
    }
    class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName} (Part Time)");
        }
    }
    class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName} (Temporary Time)");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
