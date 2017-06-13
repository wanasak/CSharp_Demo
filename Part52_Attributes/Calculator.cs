using System;

namespace Part52_Attributes
{
    public class Calculator
    {
        [Obsolete("Use method with params parameter.")]
        public static int ObsoleteAddMethod(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
                sum += number;
            return sum;
        }
    }
}
