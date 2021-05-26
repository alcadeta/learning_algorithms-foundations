using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SortingData
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {6, 20, 8, 19, 56, 23, 87, 41, 49, 53, 1};
            numbers.Dump("Begin state");

            // BubbleSort.Run(numbers);
            // numbers = MergeSort.Run(numbers);
            QuickSort.Run(numbers, 0, numbers.Count - 1);

            numbers.Dump("End state");
        }
    }
}