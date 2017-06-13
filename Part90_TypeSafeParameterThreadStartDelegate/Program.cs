using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part90_TypeSafeParameterThreadStartDelegate
{
    class Number
    {
        int _target;
        public Number(int target)
        {
            this._target = target;
        }
        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int target = Convert.ToInt32(Console.ReadLine());

            Number number = new Number(target);

            Thread thread = new Thread(new ThreadStart(number.PrintNumbers));
            thread.Start();
        }
    }
}
