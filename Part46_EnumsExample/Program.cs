using System;

namespace Part46_EnumsExample
{
    enum Gender
    {
        Unknow = 0,
        Male = 1,
        Female = 2
    }

	class Customer
	{
		public string Name { get; set; }
		public Gender Gender { get; set; }
	}

    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer()
            {
                Name = "John",
                Gender = Gender.Male
            };
            customers[1] = new Customer()
            {
                Name = "Nancy",
                Gender = Gender.Female
            };
            customers[2] = new Customer()
            {
                Name = "Sam",
                Gender = Gender.Unknow
            };
            foreach (Customer c in customers)
            {
                Console.WriteLine($"Name: {c.Name} , Gender: {GetGender(c.Gender)}");
            }
        }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknow:
                    return "Unknow";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid";
            }
        }
    }
}
