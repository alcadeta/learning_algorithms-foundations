using System;
using System.Collections.Generic;

namespace SearchingData
{
    class Program
    {
        static void Main(string[] args)
        {
            // var unordered = new List<int> {6, 20, 8, 19, 56, 23, 87, 41, 49, 53};
            // LinearSearch.Run(87, unordered);
            // LinearSearch.Run(141, unordered);

            var ordered = new List<int> {6, 8, 19, 20, 23, 41, 49, 53, 56, 87};
            BinarySearch.Run(23, ordered);
            BinarySearch.Run(87, ordered);
            BinarySearch.Run(250, ordered);
        }
    }
}