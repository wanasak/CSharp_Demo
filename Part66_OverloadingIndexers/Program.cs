using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part66_OverloadingIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            Console.WriteLine("Male employees is {0} persons", company["male"]);
            Console.WriteLine("Female employees is {0} persons", company["female"]);
        }
    }
}
