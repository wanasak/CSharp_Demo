using System;

namespace Part19_Classes
{
    class Customer
    {
        string _firstName;
        string _lastName;

		// Default Constructor - If we dont declare any constructor this will be automatically created 
		public Customer() : this("No first name", "No last name")
        { }

        // Constructor
        public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full Name: {this._firstName} {this._lastName}");
        }

        // Destructor - clean up any resoureces of class
        ~Customer()
        {

        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer("Wanasak", "Suraintaranggoon");
            c1.PrintFullName();


            Customer c2 = new Customer();
            c2.PrintFullName();
        }
    }
}
