using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// There are 5 access modifiers but you can use only 2 access modifiers for types.
// Public and Internal

namespace Part51_AccessModifiersForTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyOneClassI instance1 = new AssemblyOneClassI();
            // Cannot access internal types
            //AssemblyOneClassII instance2 = new AssemblyOneClassII();

        }
    }
}
