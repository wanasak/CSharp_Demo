using System;

// Cannot be instantiated
// Can only use as base class
// Cannot be sealed
// Can contain abstract and non abstract methods

namespace Part32_AbstractClass
{
    abstract class Customer
    {
        public abstract void Print();
        public void Print2()
        {
            Console.WriteLine("Print 2 method");
        }
    }

    class MainClass : Customer
    {
        public static void Main(string[] args)
        {
            Customer m = new MainClass();
            m.Print();
            m.Print2();
        }

        public override void Print()
        {
            Console.WriteLine("Print method");
        }
    }
}
