using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Part80_UsefulMethodsOfList
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
				Salary = 5200
			};

			Customer customer2 = new Customer()
			{
				ID = 103,
				Name = "John",
				Salary = 7000
			};

			Customer customer3 = new Customer()
			{
				ID = 102,
				Name = "Ken",
				Salary = 5500
			};

			List<Customer> listCutomers = new List<Customer>(100); // declare capacity
			listCutomers.Add(customer1);
			listCutomers.Add(customer2);
			listCutomers.Add(customer3);

            // TrueForAll() - Return true/false depending on whether all elements in the lise matches the conditions
            Console.WriteLine($"Are all salaries more than 5000? -> {listCutomers.TrueForAll(c => c.Salary > 5000)}");

            // ReadOnlyCollection() - The readonly list cannot add or remove items
            ReadOnlyCollection<Customer> readOnlyCustomers = listCutomers.AsReadOnly();

			// TrimExcess() - Sets capacity to actual number of elements int the list
			Console.WriteLine($"Capacity before trimexcess: {listCutomers.Capacity}");
            listCutomers.TrimExcess();
			Console.WriteLine($"Capacity after trimexcess: {listCutomers.Capacity}");
        }
    }
}
