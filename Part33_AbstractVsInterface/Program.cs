using System;

// Abstract Class 
// - Allow non abstract method and field
// - Can inherit only one class or multiple interfaces
// - Can have access modifiers

// Interface
// - Do not allow non abstract method and field
// - Can inherit only interface
// - Cannot have access modifiers

namespace Part33_AbstractVsInterface
{
    public abstract class Customer
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }
        public abstract void Print2();
    }

    interface ICustomer 
    {
        void Print();
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
