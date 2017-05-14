using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Generic ia allow us to design classes and methods decoupled from data types

namespace Part56_Generic
{
    class Calculator
    {
        public static bool AreEqual(int a, int b)
        {
            return a == b;
        }
        // We also use object but the problem is performance degradation
        // due to boxing and unboxing.
        // It is not type safe as well.
        public static bool AreEqual(object a, object b)
        {
            return a == b;
        }
        // Using generic
        public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            bool isEqual;
            isEqual = Calculator.AreEqual(1, 1);
            Console.WriteLine(isEqual);
            isEqual = Calculator.AreEqual("A", "B");
            Console.WriteLine(isEqual);

            isEqual = Calculator.AreEqual<int>(1, 2);
            Console.WriteLine(isEqual);
            isEqual = Calculator.AreEqual<string>("A", "A");
            Console.WriteLine(isEqual);
        }
    }
}
