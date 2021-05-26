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
    }
}