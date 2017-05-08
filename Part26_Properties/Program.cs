using System;

namespace Part26_WhyProperties
{
    class Student
    {
        //public int ID;
        //public string Name;
        //public int Age;
        private int _id;
        private string _name;
        private int _age = 24;

        public void SetID(int id)
        {
            if (id <= 0) throw new Exception("Id cannot be negative");
            this._id = id;
        }
        public int GetID()
        {
            return this._id;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new Exception("Name cannot be null or empty");
            this._name = name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
        }

        public int GetAge()
        {
            return this._age;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            //s.SetID(-1);
            s.SetID(1);
            //s.SetName("");
            s.SetName("Wanasak");

			Console.WriteLine($"Student ID: {s.GetID()}");
            Console.WriteLine($"Student Name: {s.GetName()}");
            Console.WriteLine($"Student Age: {s.GetAge()}");
        }
    }
}
