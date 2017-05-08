using System;
using System.Text;

// String is immutable, once a string object is created it cannot be changed.
// When we initialize string we get one immutable string object on the heap.
// When we concatenate word, the object is orphaned and another object is created.
// StringBuilder is mutable, a string object is created only one time. It can be changed instead of 
// create a new one.

namespace Part60_StringVsStringBuilder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userString = "C#";
            userString += " Video";
            userString += " Tutorial";
            userString += " for";
            userString += " Beginners";
            Console.WriteLine(userString);

            StringBuilder userStringBuilder = new StringBuilder("C#");
			userStringBuilder.Append(" Video");
			userStringBuilder.Append(" Tutorial");
			userStringBuilder.Append(" for");
			userStringBuilder.Append(" Beginners");
            Console.WriteLine(userStringBuilder.ToString());
        }
    }
}
