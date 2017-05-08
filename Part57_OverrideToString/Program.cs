using System;

namespace Part57_OverrideToString
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("[Customer: FirstName={0}, LastName={1}]", FirstName, LastName);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c = new Customer();
            c.FirstName = "Wanasak";
            c.LastName = "Suraintaranggon";
            Console.WriteLine(c.ToString());
        }
    }
}
