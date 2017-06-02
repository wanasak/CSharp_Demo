using System;

namespace Part23_Polymorphism
{
    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName} (Full Time)");
        }
    }
}
