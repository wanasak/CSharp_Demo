using System;

// Enums are strongly typed constants

namespace Part45_WhyEnums
{
    class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer()
            {
                Name = "John",
                Gender = 1
            };
            customers[1] = new Customer()
            {
                Name = "Nancy",
                Gender = 2
            };
			customers[2] = new Customer()
			{
				Name = "Sam",
				Gender = 0
			};
            foreach (Customer c in customers)
            {
                Console.WriteLine($"Name: {c.Name} , Gender: {GetGender(c.Gender)}");
            }
        }

		public static string GetGender(int gender)
		{
			switch (gender)
			{
				case 0:
					return "Unknow";
				case 1:
					return "Male";
				case 2:
					return "Female";
				default:
					return "Invalid";
			}
		}
    }
}
