using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part43_ExceptionHandlingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Plese enter numerator");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter dominator");
                int dominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / dominator;
                Console.WriteLine("Result = {0}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only number between {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Dominator cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
