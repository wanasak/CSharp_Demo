using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part89_ParameterThreadStartDelegate
{
    class Number
    {
        public static void PrintNumbers(object target)
        {
            if (int.TryParse(target.ToString(), out int number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            object target = Console.ReadLine();

            // Option 1
            // Create an parameterized thread start
            //ParameterizedThreadStart parameterThread = new ParameterizedThreadStart(Number.PrintNumbers);
            //Thread thread = new Thread(parameterThread);

            // Option 2
            // The compiler can implicit convert automatically
            Thread thread = new Thread(Number.PrintNumbers);

            thread.Start(target);
        }
    }
}
