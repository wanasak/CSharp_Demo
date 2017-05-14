using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part41_InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first number");
                    int fn = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number");
                    int sn = Convert.ToInt32(Console.ReadLine());

                    int result = fn / sn;
                    Console.WriteLine($"Result = {result}");
                }
                catch (Exception ex)
                {
                    string path = "C:\\NoFileHere.txt";
                    if (File.Exists(path))
                    {
                        StreamReader streamReader = new StreamReader(path);
                        Console.WriteLine(streamReader.ReadToEnd
                            ());
                    }
                    else
                        throw new FileNotFoundException("File not found", ex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Current or Outer Exception = " + ex.Message);
                if (ex.InnerException != null)
                    Console.WriteLine("Inner Exception = " + ex.InnerException.Message);

            }
        }
    }
}
