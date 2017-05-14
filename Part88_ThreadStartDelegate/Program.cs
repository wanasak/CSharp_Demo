using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part88_ThreadStartDelegate
{
    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Number.PrintNumbers);
            t1.Start();
            // ThreadStart
            Thread t2 = new Thread(new ThreadStart(Number.PrintNumbers));
            t2.Start();
        }
    }
}
