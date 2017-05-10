using System;
using System.Collections.Generic;

// Queue - FIFO (First In First Out)
// Enqueue() - To add item to the  queue
// Dequeue() - Retrive and remove first item from the queue
// Peek() - Retrive first item from the queue
// Contain() - Check exists item in the queue

namespace Part82_GenericQueue
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

            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            Customer c1 = queueCustomers.Dequeue();
			Console.WriteLine(c1.ID + " -  " + c1.Name);
			Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer c2 = queueCustomers.Peek();
			Console.WriteLine(c2.ID + " -  " + c2.Name);
			Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            if (queueCustomers.Contains(customer1))
                Console.WriteLine("Customer 1 is in Queue");
            else
                Console.WriteLine("Customer 1 is not in Queue");
		}
    }
}
