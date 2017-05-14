using System;
using System.Collections.Generic;

namespace Part76_GenericListClassAndRanges
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
			Customer customer1 = new Customer()
			{
				ID = 101,
				Name = "Mark",
				Salary = 4000,
				Type = "RetailCustomer"
			};

			Customer customer2 = new Customer()
			{
				ID = 102,
				Name = "Pam",
				Salary = 7000,
				Type = "RetailCustomer"
			};

			Customer customer3 = new Customer()
			{
				ID = 103,
				Name = "Rob",
				Salary = 5500,
				Type = "RetailCustomer"
			};

			Customer customer4 = new Customer()
			{
				ID = 104,
				Name = "John",
				Salary = 6500,
				Type = "CorporateCustomer"
			};

			Customer customer5 = new Customer()
			{
				ID = 105,
				Name = "Sam",
				Salary = 3500,
				Type = "CorporateCustomer"
			};

            List<Customer> customers1 = new List<Customer>();
			customers1.Add(customer1);
			customers1.Add(customer2);
			customers1.Add(customer3);

            List<Customer> customers2 = new List<Customer>();
			customers2.Add(customer4);
			customers2.Add(customer5);

            // AddRange()
            customers1.AddRange(customers2);
            Console.WriteLine($"Total customer list 1 = {customers1.Count} (5)");
            Console.WriteLine("------------------------------");

            // GetRange()
            List<Customer> customers3 = customers1.GetRange(2, 3);
            foreach (Customer c in customers3)
            {
                Console.WriteLine($"ID: {c.ID} Name: {c.Name}");
            }
            Console.WriteLine("------------------------------");

            // RemoveRange()
            customers1.RemoveRange(3, 2);
            Console.WriteLine($"Total customer list 1 = {customers1.Count} (3)");
			Console.WriteLine("------------------------------");

            // InsertRange()
            customers1.InsertRange(0, customers2);
			foreach (Customer c in customers1)
			{
				Console.WriteLine($"ID: {c.ID} Name: {c.Name}");
			}
			Console.WriteLine("------------------------------");
        }
    }
}
