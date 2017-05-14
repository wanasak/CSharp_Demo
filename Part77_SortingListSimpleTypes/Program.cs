using System;
using System.Collections.Generic;

namespace Part77_SortingListSimpleTypes
{
    class MainClass
    {
		class Customer
		{
			public int ID { get; set; }
			public string Name { get; set; }
			public int Salary { get; set; }
		}
		
        public static void Main(string[] args)
        {
            // Simple Types
            List<int> numbers = new List<int> { 2, 6, 1, 8, 7, 4, 3, 5, 9 };

            // Sort asc
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            // Sort desc
            numbers.Reverse();
			foreach (int number in numbers)
			{
				Console.WriteLine(number);
			}

            // Complex Types
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
				ID = 103,
				Name = "Rob",
				Salary = 5500
			};

			List<Customer> listCustomers = new List<Customer>();
			listCustomers.Add(customer1);
			listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            listCustomers.Sort(); // throw error
        }
    }
}
