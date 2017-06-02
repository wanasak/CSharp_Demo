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
}
