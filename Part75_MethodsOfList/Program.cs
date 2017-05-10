using System;
using System.Collections.Generic;
using System.Linq;

// Contains()
// Exists()
// Find()
// FindLast()
// FindAll()
// FindIndex()
// FindLastIndex()
// ToList()
// ToArray()
// ToDictionary()

namespace Part75_MethodsOfList
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
				Salary = 4000
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

            Customer[] customersArray = new Customer[3];
			customersArray[0] = customer1;
			customersArray[1] = customer2;
			customersArray[2] = customer3;

            // To convert an array to list
            List<Customer> customersList = customersArray.ToList();
            foreach (Customer c in customersList)
            {
                Console.WriteLine($"ID: {c.ID}, Name: {c.Name}");
            }
			Console.WriteLine("---------------------------------------");

            // To convert a list to array
            Customer[] customersArray2 = customersList.ToArray();
			foreach (Customer c in customersArray2)
			{
				Console.WriteLine($"ID: {c.ID}, Name: {c.Name}");
			}
			Console.WriteLine("---------------------------------------");

            // To convert a list to dictionary
            Dictionary<int, Customer> customersDictionary = customersList.ToDictionary(c => c.ID, c => c);
            foreach (KeyValuePair<int, Customer> kpv in customersDictionary)
            {
                Console.WriteLine($"ID: {kpv.Key}, Name: {kpv.Value.Name}");
            }
            Console.WriteLine("---------------------------------------");

            // To check an item exists
            if (customersList.Contains(customer2)) 
                Console.WriteLine("Customer2 contain");
            
            if (customersList.Exists(c => c.Name.StartsWith("M")))
                Console.WriteLine("Customer1 exists");

            // To find an item 
            Customer mark = customersList.Find(c => c.Name == "Mark");
            if (mark != null) Console.WriteLine("Find mark");

            Customer pam = customersList.FindLast(c => c.Salary > 0);
            if (pam != null) Console.WriteLine("FindLast pam");

            List<Customer> filteredCustomers = customersList.FindAll(c => c.Salary > 0);
			foreach (Customer c in filteredCustomers)
			{
				Console.WriteLine($"ID: {c.ID}, Name: {c.Name}");
			}

            int firstIndex = customersList.FindIndex(c => c.Salary == 5500);
            Console.WriteLine($"Index of first matching customer whose salary is 5500 = {firstIndex}");

            int lastIndex = customersList.FindLastIndex(c => c.Salary > 0);
			Console.WriteLine($"Index of last matching customer whose salary more than 0 = {lastIndex}");
        }
    }
}
