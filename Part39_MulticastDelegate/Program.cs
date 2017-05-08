using System;

namespace Part39_MulticastDelegate
{
    public delegate void SampleDelegate();

    class MainClass
    {
        public static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(MethodOne);
            del += MethodTwo;
            del += MethodThree;

            del();
        }

        public static void MethodOne()
        {
            Console.WriteLine("Method one");
        }
		public static void MethodTwo()
		{
			Console.WriteLine("Method two");
		}
		public static void MethodThree()
		{
			Console.WriteLine("Method three");
		}
    }
}
