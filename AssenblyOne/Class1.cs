using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        internal int ID = 999;
        protected internal string Name = "Wanasak";
    }

    internal class AssemblyOneClassII
    {
        public void Test()
        {
            AssemblyOneClassI instance = new AssemblyOneClassI();
            Console.WriteLine(instance.ID); // Access internal member ID
            Console.WriteLine(instance.Name); // Access protected internal member Name
        }
    }
    class AssemblyOneIII : AssemblyOneClassII
    {

    }
}
