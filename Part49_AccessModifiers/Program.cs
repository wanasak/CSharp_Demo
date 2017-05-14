using System;

// There are 5 access modifiers
// 1) Private - Available in the containing type
// 2) Public - Avaiable everywhere
// 3) Protected - Avaiable in containig type and derived containig type
// 4) Internal - Avaiable in containing assembly
// 5) Protected Internal - Available in containing assembly and derived class in any another assembly

namespace Part49_AccessModifiers
{
    public class Customer
    {
        private int _id;
        protected string _name;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual void PrintName()
        {
            Console.WriteLine(this._name);
        }
    }
    public class GoldCustomer : Customer
    {
        public override void PrintName()
        {
            Console.WriteLine(base._name);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
			Customer CustomerInstance = new Customer();
			CustomerInstance.ID = 101; // Access public
            //CustomerInstance._id = 102 // Cannot access private
        }
    }
}
