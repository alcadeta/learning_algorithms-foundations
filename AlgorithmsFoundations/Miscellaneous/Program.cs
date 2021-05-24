using System;
using System.Collections.Generic;
using SearchingData;

namespace Miscellaneous
{
    class Program
    {
        static void Main(string[] args)
        {
            // var numbers = new List<int> {6, 20, 8, 19, 56, 23, 87, 41, 49, 53};
            // var orderedNumbers = new List<int> {6, 8, 19, 20, 23, 41, 49, 53, 56, 87};

            // IsSorted.Run(numbers);
            // IsSorted.Run(orderedNumbers);

            var items = new List<string>
            {
                "apple", "pear", "orange", "banana", "apple", "orange", "apple",
                "pear", "banana", "orange", "apple", "kiwi", "pear", "apple", "orange"
            };

            // UniqueFiltering.Run(items).ForEach(Console.WriteLine);
            var result = ValueCounting.Run(items);
            foreach (var (key, value) in result)
                Console.WriteLine($"Item: {key} — Count: {value}");
        }
    }
}