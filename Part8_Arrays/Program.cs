using System;

// Advantages - Arrays are strongly type
// Disadvantages - Arrays cannot grow in size once initialize, 
//                 Have to rely on integral indices to store or retrive items

namespace Part8_Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Initialize and assign values
            int[] evenNumbers = new int[3];
            evenNumbers[0] = 2;
            evenNumbers[1] = 4;
            evenNumbers[2] = 6;

            // Initialize and assign values in the same line
            int[] oddNumbers = { 1, 3, 5 };

            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }

            for (int i = 0; i < oddNumbers.Length; i++)
			{
				Console.WriteLine(oddNumbers[i]);
			}
        }
    }
}
