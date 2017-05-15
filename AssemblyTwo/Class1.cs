using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
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
}
