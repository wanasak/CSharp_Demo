using System;

namespace Part23_Polymorphism
{
    class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName} (Temporary Time)");
        }
    }
}
