using System;
using System.Collections.Generic;

namespace Part79_SortListComplexTypesUsingComparisonDelegate
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
			Customer customer1 = new Customer()
			{
				ID = 103,
				Name = "Mark",
				Salary = 4000
			};

			Customer customer2 = new Customer()
			{
				ID = 102,
				Name = "John",
				Salary = 7000
			};

			Customer customer3 = new Customer()
			{
				ID = 101,
				Name = "Ken",
				Salary = 5500
			};

			List<Customer> listCutomers = new List<Customer>();
			listCutomers.Add(customer1);
			listCutomers.Add(customer2);
			listCutomers.Add(customer3);

            // Approach 1
            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);
            listCutomers.Sort(customerComparer);
			Console.WriteLine("Customers sort by name");
			foreach (Customer c in listCutomers)
			{
				Console.WriteLine($"ID: {c.ID} Name: {c.Name} Salary: {c.Salary}");
			}

            // Approach 2
            listCutomers.Sort(delegate(Customer c1, Customer c2) {
                return c1.ID.CompareTo(c2.ID);
            });
			foreach (Customer c in listCutomers)
			{
				Console.WriteLine($"ID: {c.ID} Name: {c.Name} Salary: {c.Salary}");
			}

            // Approach 3 - using lamda expression
            listCutomers.Sort((x, y) => x.ID.CompareTo(y.ID));
			foreach (Customer c in listCutomers)
			{
				Console.WriteLine($"ID: {c.ID} Name: {c.Name} Salary: {c.Salary}");
			}
        }

        private static int CompareCustomer(Customer c1, Customer c2)
        {
            return c1.ID.CompareTo(c2.ID);
        }
    }
}
