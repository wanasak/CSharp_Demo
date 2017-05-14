using System;
using System.Collections.Generic;

namespace Part78_SortingListComplexTypes
{
    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
