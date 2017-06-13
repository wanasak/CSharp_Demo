using System;

namespace Part53_Reflection
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public void PrintId()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
