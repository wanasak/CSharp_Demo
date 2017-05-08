using System;

// Inheritance - code reuse
// allow only one class inheritance
// allow multiple interface inheritance
// base classes are instantiated before derived classes
// base class constructor executes before derived class constructor

namespace Part21_Inheritance
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public Employee()
        {
            Console.WriteLine("Base class constructor initialized.");
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }

    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee()
        {
            Console.WriteLine("Derived class constructor initialized.");
        }

        public float YearSalary { get; set; }
    }

    class PartTimeEmployee : Employee
    {
		public PartTimeEmployee()
		{
			Console.WriteLine("Derived class constructor initialized.");
		}

        public float HourlyRate { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Wanasak";
            fte.LastName = "Suraintaranggoon";
            fte.Email = "wanasak@gmail.com";
            fte.YearSalary = 10000;

            PartTimeEmployee pte = new PartTimeEmployee();
			pte.FirstName = "Wanasak";
			pte.LastName = "Suraintaranggoon";
			pte.Email = "wanasak@gmail.com";
            pte.HourlyRate = 10;
        }
    }
}
