using System;
using System.Collections.Generic;
using System.Linq;

// TryGet()
// Count()
// Remove()
// Clear()
// Using LINQ extension method
// Convert array to dictionary

namespace Part73_MethodsOfDictionary
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
			Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

			Customer customr1 = new Customer()
			{
				ID = 101,
				Name = "Mark",
				Salary = 5000
			};

			Customer customr2 = new Customer()
			{
				ID = 102,
				Name = "Pam",
				Salary = 7000
			};

			Customer customr3 = new Customer()
			{
				ID = 104,
				Name = "Rob",
				Salary = 5500
			};

			// Add customer object to the dictionary
			dictionaryCustomers.Add(customr1.ID, customr1);
			dictionaryCustomers.Add(customr2.ID, customr2);
			dictionaryCustomers.Add(customr3.ID, customr3);

            // Tryget() method to get value from a dictionary
            Customer c999;
            if (dictionaryCustomers.TryGetValue(999, out c999))
                Console.WriteLine($"Name: {c999.Name}, Salary: {c999.Salary}");
            else
                Console.WriteLine("Customer Id 999 was not found");
            Console.WriteLine("--------------------------------------------------");

            // Count() method to get total
            Console.WriteLine($"Total customers: {dictionaryCustomers.Count()}");
            Console.WriteLine("--------------------------------------------------");

			// LINQ extension methods can be used with dictionary
            Console.WriteLine($"Tota customer's salary more than 5000: {dictionaryCustomers.Count(c => c.Value.Salary > 5000)}");
			Console.WriteLine("--------------------------------------------------");

            // To remove an item from the dictionary
            dictionaryCustomers.Remove(101);

            // To remove all items from the dictionary
            dictionaryCustomers.Clear();

            Customer[] customers = new Customer[3];
			customers[0] = customr1;
			customers[1] = customr2;
			customers[2] = customr3;

            // Convert customer array to a dictionary
            Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            foreach (KeyValuePair<int, Customer> kpv in dict)
            {
				int customerID = kpv.Key;
				Customer c1 = kpv.Value;
				Console.WriteLine($"Name: {c1.Name}, Salary: {c1.Salary}");
            }
		}
	}
}
