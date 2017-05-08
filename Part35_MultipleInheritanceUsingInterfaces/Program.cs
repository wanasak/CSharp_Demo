using System;

namespace Part35_MultipleInheritanceUsingInterfaces
{
    interface IA
    {
        void AMethod();
    }
    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A method");
        }
    }

    interface IB
    {
        void BMethod();
    }
    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B method");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }
}
