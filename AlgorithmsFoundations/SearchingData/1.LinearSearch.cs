using System;
using System.Collections.Generic;

namespace SearchingData
{
    /// <summary>
    /// When dealing with an unsorted sequence, there isn't much we can do other
    /// than to check each element one by one until we find the item that's
    /// being searched. This is called a linear search.
    /// </summary>
    public class LinearSearch
    {
        public static void Run(int number, List<int> numbers)
        {
            for (var i = 0; i < numbers.Count; i++)
                if (numbers[i] == number)
                {
                    Console.WriteLine($"Item found at index {i}.");
                    return;
                }

            Console.WriteLine($"Item not found.");
        }
    }
}