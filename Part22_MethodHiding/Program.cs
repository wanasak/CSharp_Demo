using System;

namespace Part22_MethodHiding
{
    class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName} (Employee)");
        }
    }

    class FullTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName} (Full Time)");
        }
    }

    class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            base.PrintFullName();
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Wanasak";
            fte.LastName = "Suraintaranggoon";
            fte.PrintFullName();
            ((Employee)fte).PrintFullName(); // call from base class

            Employee pte = new PartTimeEmployee();
            pte.FirstName = "Wanasak";
            pte.LastName = "Suraintaranggoon";
            pte.PrintFullName();
        }
    }
}
