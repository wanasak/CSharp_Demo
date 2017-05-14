using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part47_EnumsConcept
{
    enum Gender
    {
        Unknow,
        Male, 
        Female
    }
    enum Gender2 : short
    {
        Unknow = 1,
        Male = 2,
        Female = 3
    }
    enum Gender3 : short
    {
        Unknow = 10,
        Male = 20,
        Female = 30
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] genderValues = (int[])Enum.GetValues(typeof(Gender));
            foreach (int value in genderValues)
            {
                Console.WriteLine(value);
            }

            string[] genderNames = (string[])Enum.GetNames(typeof(Gender));
            foreach (string value in genderNames)
            {
                Console.WriteLine(value);
            }
        }
    }
}
