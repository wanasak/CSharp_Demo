using System;
using System.Collections.Generic;

// A dictionary is a collection of key-value pairs
// Present in System.Collections.Generic namespace
// When creating a dictionary, we need to specify the type for key and value
// Keys must be unique
// Fasr lookup for values using keys

namespace Part72_Dictionary
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

            // Retrive the value from dictionary, using key
            Customer c = dictionaryCustomers[101];
            Console.WriteLine($"Name: {c.Name}, Salary: {c.Salary}");
            Console.WriteLine("--------------------------------------------------");

            // It is possible to loop thru each key/value pair
            foreach (KeyValuePair<int, Customer> kpv in dictionaryCustomers)
            {
                int customerID = kpv.Key;
                Customer c1 = kpv.Value;
                Console.WriteLine($"Name: {c1.Name}, Salary: {c1.Salary}");
            }
            Console.WriteLine("--------------------------------------------------");

            // To get all keys 
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine($"Key: {key}");
            }
            Console.WriteLine("--------------------------------------------------");

            // To get all values
            foreach (Customer customer in dictionaryCustomers.Values)
            {
                Console.WriteLine($"Name: {customer.Name}, Salary: {customer.Salary}");
            }
            Console.WriteLine("--------------------------------------------------");

            // When access a dictionary by key, you should check the key already exists
            if (dictionaryCustomers.ContainsKey(101))
                Console.WriteLine("Customer Id 101 is found");
            else
                Console.WriteLine("Customer Id 101 was not found");
        }
    }
}
