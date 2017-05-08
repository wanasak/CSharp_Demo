using System;

namespace Part27_Properties
{
    class Student
    {
        private int _id;
        private string _name;
        private int _age = 24;
        private string _email;

        public int ID
        {
            get { return this._id; }
            set
            {
                if (value <= 0) throw new Exception("Id cannot be negative");
                this._id = value;
            }
        }
        public string Name
        {
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Name cannot be null or empty");
                this._name = value;
            }
        }
        // readonly
        public int Age
        {
            get
            {
                return this._age;
            }
        }
        public string Email { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
			Student s = new Student();
            s.ID = 1;
            s.Name = "Wanasak";

			Console.WriteLine($"Student ID: {s.ID}");
            Console.WriteLine($"Student Name: {s.Name}");
			Console.WriteLine($"Student Age: {s.Age}");
        }
    }
}
