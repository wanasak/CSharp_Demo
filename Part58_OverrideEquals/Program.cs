using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part58_OverrideEquals
{
    public enum Direction
    {
        East =1,
        West = 2,
        North = 3,
        South = 4
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Customer == false) return false;
            return (this.FirstName == ((Customer)obj).FirstName) && (this.LastName == ((Customer)obj).LastName);
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.East;
            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));

            Customer customer1 = new Customer("John", "Liquid");
            Customer customer2 = customer1;
            Console.WriteLine(customer1 == customer2);
            Console.WriteLine(customer1.Equals(customer2));

            Customer customer3 = new Customer("Jay", "Liquid");
            Customer customer4 = new Customer("Jay", "Liquid");
            Console.WriteLine(customer3 == customer4);
            Console.WriteLine(customer3.Equals(customer4));
        }
    }
}
