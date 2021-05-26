using System;
using System.Collections.Generic;
using SearchingData;

namespace Miscellaneous
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** IS-SORTED *** //
            // var numbers = new List<int> {6, 20, 8, 19, 56, 23, 87, 41, 49, 53};
            // var orderedNumbers = new List<int> {6, 8, 19, 20, 23, 41, 49, 53, 56, 87};

            // IsSorted.Run(numbers);
            // IsSorted.Run(orderedNumbers);


            // *** UNIQUE FILTERING AND VALUE COUNTING *** //
            // var items = new List<string>
            // {
            //     "apple", "pear", "orange", "banana", "apple", "orange", "apple",
            //     "pear", "banana", "orange", "apple", "kiwi", "pear", "apple", "orange"
            // };
            //
            // UniqueFiltering.Run(items).ForEach(Console.WriteLine);
            // var result = ValueCounting.Run(items);
            // foreach (var (key, value) in result)
            //     Console.WriteLine($"Item: {key} — Count: {value}");


            // *** RECURSION *** //
            // Recursion.Countdown(10);
            // Console.WriteLine($"5 to the power of 3 is {Recursion.Power(5, 3)}");
            // Console.WriteLine($"1 to the power of 5 is {Recursion.Power(1, 5)}");
            Console.WriteLine($"4! is {Recursion.Factorial(4)}");
            Console.WriteLine($"0! is {Recursion.Factorial(0)}");
        }
    }
}