using System;

namespace Part28_Structs
{
    struct Customer
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return this._id; } 
            set { this._id = value; }
        }
        public string Name
		{
            get { return this._name; }
            set { this._name = value; }
		}

        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {this._id} Name : {this._name}");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c = new Customer(1, "Wanasak");
            c.PrintDetails();

            Customer c1 = new Customer();
            c1.Name = "Wanasak";
            c1.ID = 2;
            c1.PrintDetails();
        }
    }
}
