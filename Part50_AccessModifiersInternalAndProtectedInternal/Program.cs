using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part50_AccessModifiersInternalAndProtectedInternal
{
    public class AssemblyTwoClassI
    {
        public void Test()
        {
            //Console.WriteLine(base.ID); // Cannot access internal
            //Console.WriteLine(base.Name); // Cannot access protected internal
        }
    }

    public class AssemblyTwoClassII : AssemblyOneClassI
    {
        public void Test()
        {
            //Console.WriteLine(base.ID); // Cannot access internal
            Console.WriteLine(base.Name); // Can access protected internal
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
