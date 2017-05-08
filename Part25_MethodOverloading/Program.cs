using System;

namespace Part25_MethodOverloading
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Add(5, 10);
            Add(5, 10, 15);
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

		public static void Add(int a, int b, int c, int d)
		{
			Console.WriteLine(a + b + c + d);
		}

        public static void Add(float a, float b)
        {
            Console.WriteLine(a + b);
        }
    }
}
