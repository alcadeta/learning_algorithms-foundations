using System;
using System.Collections.Generic;

namespace SearchingData
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {6, 20, 8, 19, 56, 23, 87, 41, 49, 53};

            LinearSearch.Run(87, numbers);
            LinearSearch.Run(141, numbers);
        }
    }
}