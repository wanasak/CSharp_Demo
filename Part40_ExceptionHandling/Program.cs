using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// An exception is an unforceseen error that occurs when program is running
// Try - The code that can possibly cause an exception
// Catch - Handles the exception
// Finally - Clean and free resource

namespace Part40_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader("C:\\NoFileHere.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Please chack the file {ex.FileName} is present.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
            }
        }
    }
}
