using System;
using System.Collections.Generic;

namespace Part78_SortingListComplexTypes
{
    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
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
				Name = "John",
				Salary = 7000
			};

			Customer customer3 = new Customer()
			{
				ID = 103,
				Name = "Ken",
				Salary = 5500
			};

			List<Customer> listCutomers = new List<Customer>();
			listCutomers.Add(customer1);
			listCutomers.Add(customer2);
			listCutomers.Add(customer3);

            Console.WriteLine("Customers before sorting");
            foreach (Customer c in listCutomers)
            {
                Console.WriteLine($"ID: {c.ID} Name: {c.Name} Salary: {c.Salary}");
            }

            listCutomers.Sort();
			Console.WriteLine("Customers sort by salary");
			foreach (Customer c in listCutomers)
			{
				Console.WriteLine($"ID: {c.ID} Name: {c.Name} Salary: {c.Salary}");
			}

            SortByName sortByName = new SortByName();
            listCutomers.Sort(sortByName);
			Console.WriteLine("Customers sort by name");
			foreach (Customer c in listCutomers)
			{
				Console.WriteLine($"ID: {c.ID} Name: {c.Name} Salary: {c.Salary}");
			}
        }
    }
}
