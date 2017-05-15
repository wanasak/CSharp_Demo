using System;

// Implicit conversions - No loss data and exception
// Explicit conversion - Data and exception will be lost
// Parse vs TryParse - If the number is in string format
// Parse - Throws an exception if cannot parse the value
// TryParse -

namespace Part07_DataTypeConversions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Implicit
            int i = 10;
            float j = i;
            Console.WriteLine(j);

            // Explicit
            float a = 20.25F;
            int b = (int)a;
            int c = Convert.ToInt32(a);
			Console.WriteLine(b);
			Console.WriteLine(c);

            // Parse
            //string d = "30x";
            //int e = int.Parse(d); // throws exception
            //Console.WriteLine(e);
            string f = "30";
            int g = int.Parse(f);
			Console.WriteLine(g);

            // TryParse
            string h = "40";
            int result = 0;
            bool isConversionSuccesful = int.TryParse(h, out result);
            if (isConversionSuccesful)
                Console.WriteLine(result);
            else
                Console.WriteLine("Parse method is failed.");
        }
    }
}
