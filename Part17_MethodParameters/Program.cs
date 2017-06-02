using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part17_MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            SimpleMethodValueParameter(i);

            // Print 0
            Console.WriteLine(i.ToString());

            SimpleMethodRefParameter(ref i);
            // Print 2
            Console.WriteLine(i.ToString());

            int sum, multiply = 0;
            SimpleMethodOutputParameter(2, 5, out sum, out multiply);
            Console.WriteLine("Sum = {0}, Multiply = {1}", sum, multiply);

            int result = SimpleMethodParamsParameter(1, 2, 3, 4, 5);
            Console.WriteLine(result.ToString());

            Console.ReadKey();
        }

        static void SimpleMethodValueParameter(int j)
        {
            j = 1;
        }

        static void SimpleMethodRefParameter(ref int j)
        {
            j = 2;
        }

        static void SimpleMethodOutputParameter(int fn, int sn, out int sum, out int multiply)
        {
            sum = fn + sn;
            multiply = fn * sn;
        }

        static int SimpleMethodParamsParameter(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
