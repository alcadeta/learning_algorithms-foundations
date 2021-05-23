using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SortingData
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {6, 20, 8, 19, 56, 23, 87, 41, 49, 53};
            BubbleSort.Run(numbers);
        }
    }
}