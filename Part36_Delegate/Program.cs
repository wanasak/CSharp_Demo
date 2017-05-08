using System;

// Delegate is a type safe function pointer

namespace Part36_Delegate
{
    public delegate void HelloDelegate(string msg);

    class MainClass
    {
        public static void Main(string[] args)
        {
            // point to function
            HelloDelegate hd = new HelloDelegate(Hello);
            hd("Hello Delegate");
        }

        public static void Hello(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
