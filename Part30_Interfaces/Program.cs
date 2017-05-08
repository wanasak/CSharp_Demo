using System;

namespace Part30_Interfaces
{
    interface ICustomer
    {
        void Print();
    }
    interface ICustomer2
    {
        void Print2();
    }

    class Customer : ICustomer, ICustomer2
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void Print2()
        {
            Console.WriteLine("Print2");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print();
            c1.Print2();
        }
    }
}
