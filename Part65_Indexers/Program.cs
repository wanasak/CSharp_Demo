using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part65_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            var employee1 = company[1];
            Console.WriteLine("Frist Employee Name = {0}", employee1);
            company[1] = "John";
            Console.WriteLine("Edit First Employee Name = {0}", company[1]);
        }
    }
}
