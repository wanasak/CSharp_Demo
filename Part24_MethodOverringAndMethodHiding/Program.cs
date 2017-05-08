using System;

// Overring Method - A base class reference variable pointing to a child class object, will invoke the overridden method in child class
// Method Hiding - A base class reference variable pointing to a child class object, will invoke the hidden method in base class

namespace Part24_MethodOverringAndMethodHiding
{
    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base class print method");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("Derived class print method");
        }
    }

    class DerivedClass2 : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("Derived2 class print method");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            BaseClass b = new DerivedClass();
            b.Print(); // print derived method

            DerivedClass d = new DerivedClass();
            d.Print(); // print derived method

			BaseClass b1 = new DerivedClass2();
            b1.Print(); // print base method

			DerivedClass2 d1 = new DerivedClass2();
            d1.Print();  // print derived2 method
		}
    }
}
