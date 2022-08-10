using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumProblemUsingGenerics
{
    public class MaxNumbers
    {
        public static void maxNumbers()
        {
            int num1 = 554;
            int num2 = 222;
            int num3 = 822;
            int num4 = 220;

            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 && num1.CompareTo(num4) > 0 ||
               num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 && num1.CompareTo(num4) > 0 ||
                num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0 && num1.CompareTo(num4) > 0 ||
                num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 && num1.CompareTo(num4) >= 0)

            {
                Console.WriteLine("num 1 is greater " + num1);
            }

            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 && num2.CompareTo(num4) > 0 ||
               num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 && num2.CompareTo(num4) > 0 ||
                num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0 && num2.CompareTo(num4) > 0 ||
                num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 && num2.CompareTo(num4) >= 0)
            {
                Console.WriteLine("num 2 is greater " + num2);
            }

            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 && num3.CompareTo(num4) > 0 ||
               num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 && num3.CompareTo(num4) > 0 ||
                num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0 && num3.CompareTo(num4) > 0 ||
                num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 && num3.CompareTo(num4) >= 0)
            {
                Console.WriteLine("num 3 is greater " + num3);
            }

            if (num4.CompareTo(num1) > 0 && num4.CompareTo(num2) > 0 && num4.CompareTo(num3) > 0 ||
               num4.CompareTo(num1) >= 0 && num4.CompareTo(num2) > 0 && num4.CompareTo(num3) > 0 ||
                num4.CompareTo(num1) > 0 && num4.CompareTo(num2) >= 0 && num4.CompareTo(num3) > 0 ||
                num4.CompareTo(num1) > 0 && num4.CompareTo(num2) > 0 && num4.CompareTo(num3) >= 0)
            {
                Console.WriteLine("num 4 is greater " + num4);
            }
            Console.ReadKey();
        }
    }
}
