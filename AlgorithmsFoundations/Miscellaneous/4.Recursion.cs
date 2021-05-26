using System;

namespace Miscellaneous
{
    public class Recursion
    {
        public static void Countdown(int x)
        {
            if (x == 0) Console.WriteLine(x);
            else
            {
                Console.WriteLine($"{x} ...");
                Countdown(x - 1);
            }
        }

        public static int Power(int num, int pwr) =>
            pwr == 0 ? 1
                     : num * Power(num, pwr - 1);
    }
}