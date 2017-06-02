namespace Part61_PartialClass
{
    public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;
        public string Firstname
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string Lasttname
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
