using System;

namespace Part23_Polymorphism
{
    class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName} (Part Time)");
        }
    }
}
