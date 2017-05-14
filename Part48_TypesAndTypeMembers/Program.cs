using System;

// Types -> classes, structs, enums, interfaces, delegates
// Can have 2 access modifiers, public and internal
// Type Members -> fields, properties, constructors, methods
// Can have all access modifiers

namespace Part48_TypesAndTypeMembers
{
    class Customer //Type
    {
        // Type members
        #region fields
        private int _id;
        private string _firstName;
        private string _lastName;
        #endregion

        #region properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
        #endregion
        // End type members
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

        }
    }
}
