using System;
using System.Collections.Generic;

// Dictionary
// Lsit
// Stack
// Queue

namespace Part74_ListCollection
{
    class Customer
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int Salary { get; set; }
	}

    class MainClass
    {
        public static void Main(string[] args)
        {
			Customer customer1 = new Customer()
			{
				ID = 101,
				Name = "Mark",
				Salary = 5000
			};

			Customer customer2 = new Customer()
			{
				ID = 102,
				Name = "Pam",
				Salary = 7000
			};

			Customer customer3 = new Customer()
			{
				ID = 104,
				Name = "Rob",
				Salary = 5500
			};

			Customer[] arrayCustomers = new Customer[2];
			arrayCustomers[0] = customer1;
			arrayCustomers[1] = customer2;
			//arrayCustomers[2] = customer3;

            List<Customer> listCustomers = new List<Customer>(2);
			listCustomers.Add(customer1);
            listCustomers.Add(customer2);
			listCustomers.Add(customer3);

            // Items can be retrived from the list by index
            Customer c1 = listCustomers[0];
            Console.WriteLine($"ID: {c1.ID}, Name: {c1.Name}, Salary: {c1.Salary}");
            Console.WriteLine("------------------------------------------------");

            // Foreach items in the list
            foreach (Customer c2 in listCustomers)
            {
                Console.WriteLine($"ID: {c2.ID}, Name: {c2.Name}, Salary: {c2.Salary}");
            }
            Console.WriteLine("------------------------------------------------");

            // Insert
            listCustomers.Insert(1, customer3);
            Console.WriteLine($"ID: {listCustomers[1].ID}, Name: {listCustomers[1].Name}");
            Console.WriteLine("------------------------------------------------");

            // To get the index of specific item
            Console.WriteLine($"Index of customer1 is: {listCustomers.IndexOf(customer1)}");
            Console.WriteLine("------------------------------------------------");
        }
    }
}
