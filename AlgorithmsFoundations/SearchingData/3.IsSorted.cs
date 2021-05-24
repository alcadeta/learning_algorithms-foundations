using System;
using System.Collections.Generic;

namespace SearchingData
{
    /// <summary>
    /// Determining whether a sequence is sorted.
    /// </summary>
    public class IsSorted
    {
        public static void Run(List<int> numbers)
        {
            for (var i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] <= numbers[i + 1]) continue;
                Console.WriteLine("The numbers are NOT sorted.");
                return;
            }

            Console.WriteLine("The numbers ARE sorted.");
        }
    }
}