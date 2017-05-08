using System;

// There are 4 ways that can be used to make method parameters optional
// 1) Use parameter arrays
// 2) Method overloading
// 3) Specify param defaults
// 4) Use OptionalAttribute 

namespace Part67_OptionalParameter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AddNumbers(10, 20);
            AddNumbers(10, 20, new int[] { 30, 40, 50 });

            AddNumbersOverloading(10, 20, new int[] { 30, 40, 50 });
            AddNumbersOverloading(10, 20);

            AddNumbersSpecifyDefault(10, 20);
            AddNumbersSpecifyDefault(10, 20, new int[] { 30, 40, 50 });

            AddNumbersOptionalAttribute(10, 20);
            AddNumbersOptionalAttribute(10, 20, new int[] { 30, 40, 50 });
        }


        // first way
        public static void AddNumbers(int firstNumber, int secondNumber, params int[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }
            Console.WriteLine($"Total: {result}");
        }

        // second way
        public static void AddNumbersOverloading(int firstNumber, int secondNumber, int[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine($"Total: {result}");
        }
        public static void AddNumbersOverloading(int firstNumbers, int secondNumbers)
        {
            AddNumbersOverloading(firstNumbers, secondNumbers, null);
        }

        // third way
        public static void AddNumbersSpecifyDefault(int firstNumber, int secondNumber, int[] restOfTheNumbers = null)
        {
            int result = firstNumber + secondNumber;
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine($"Total: {result}");
        }

        // forth way
        public static void AddNumbersOptionalAttribute(int firstNumbers, int secondNumbers, [System.Runtime.InteropServices.Optional]int[] restOfTheNumbers)
        {
            int result = firstNumbers + secondNumbers;
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine($"Total: {result}");
        }
    }
}
