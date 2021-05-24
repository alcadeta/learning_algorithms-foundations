using System;
using System.Collections.Generic;

namespace SearchingData
{
    /// <summary>
    /// When dealing with a sorted sequence, we can take advantage of the fact
    /// that the items are sorted to use the binary search algorithm. Binary
    /// search algorithm starts with setting two indexes — one at the beginning
    /// and one at the end of the sequence. Then it calculates the mid-point of
    /// the list and compares it to the number that's being search, determining
    /// whether they're equal (item is found), lesser than the number that's
    /// being searched (set the lower index to the middle), or greater than the
    /// number being searched (set the upper index to the middle. It repeats
    /// this process until either the number is found or the indexes cross each
    /// other, indicating that the number is not found.
    /// </summary>
    public class BinarySearch
    {
        public static void Run(int number, List<int> numberList)
        {
            var lowerIndex = 0;
            var upperIndex = numberList.Count - 1;

            // Breaks if indexes have crossed each other.
            while (lowerIndex <= upperIndex)
            {
                var midPoint = (lowerIndex + upperIndex) / 2;

                if (numberList[midPoint] == number)
                {
                    Console.WriteLine($"The number is found at index {midPoint}.");
                    return;
                }


                if (number > numberList[midPoint])
                    lowerIndex = midPoint + 1;
                else
                    upperIndex = midPoint - 1;
            }

            Console.WriteLine("The number is not found.");
        }
    }
}