using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part44_PreventExceptionshandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Plese enter numerator");
                bool isNumerator = Int32.TryParse(Console.ReadLine(), out int numerator);

                if (isNumerator == false)
                {
                    Console.WriteLine("Numerator should be a number");
                }

                Console.WriteLine("Please enter dominator");
                bool isDominator = Int32.TryParse(Console.ReadLine(), out int dominator);

                if (isDominator && dominator != 0)
                {
                    int result = numerator / dominator;
                    Console.WriteLine("Result = {0}", result);
                }
                else
                {
                    if (dominator == 0)
                    {
                        Console.WriteLine("Dominator cannot be zero");
                    }
                    else
                    {
                        Console.WriteLine("Dominator should be a number and between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
