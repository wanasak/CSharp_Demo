using System;

namespace Part31_ExplicitInterface
{
    interface I1
    {
        void Print();
    }
    interface I2
    {
        void Print();
    }

    class MainClass : I1, I2
    {
        public static void Main(string[] args)
        {
            MainClass m = new MainClass();
			((I1)m).Print();
			((I2)m).Print();
        }

        // explicit interface
        void I1.Print()
        {
            Console.WriteLine("Interface 1 print");
        }
        void I2.Print()
        {
            Console.WriteLine("Interface 2 print");
        }
    }
}
