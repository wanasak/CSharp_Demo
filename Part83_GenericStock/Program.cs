using System;
using System.Collections.Generic;

// Stack - LIFO (Last In First Out)
// Push() - Insert item 
// Pop() - Remove and return item
// Peek() - Return item
// Contain() - Check exists

namespace Part83_GenericStack
{
	public class Customer
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
	}

    class MainClass
    {
        public static void Main(string[] args)
        {
			Customer customer1 = new Customer()
			{
				ID = 101,
				Name = "Mark",
				Gender = "Male"
			};

			Customer customer2 = new Customer()
			{
				ID = 102,
				Name = "Pam",
				Gender = "Female"
			};

			Customer customer3 = new Customer()
			{
				ID = 103,
				Name = "John",
				Gender = "Male"
			};

			Customer customer4 = new Customer()
			{
				ID = 104,
				Name = "Ken",
				Gender = "Male"
			};

			Customer customer5 = new Customer()
			{
				ID = 105,
				Name = "Valarie",
				Gender = "Female"
			};

            Stack<Customer> stackCustomers = new Stack<Customer>();
			stackCustomers.Push(customer1);
			stackCustomers.Push(customer2);
			stackCustomers.Push(customer3);
			stackCustomers.Push(customer4);
			stackCustomers.Push(customer5);

			Customer c5 = stackCustomers.Pop();
			Console.WriteLine(c5.ID + " -  " + c5.Name);
			Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer c4 = stackCustomers.Peek();
			Console.WriteLine(c4.ID + " -  " + c4.Name);
			Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            if (stackCustomers.Contains(customer5))
				Console.WriteLine("Customer 5 is in Stack");
			else
				Console.WriteLine("Customer 5 is not in Stack");
        }
    }
}
