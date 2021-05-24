using System.Collections.Generic;
using System.Linq;

namespace SortingData
{
    public static class MergeSort
    {
        public static List<int> Run(List<int> numbers)
        {
            if (numbers.Count <= 1) return numbers;

            // 1. SPLIT THE ARRAYS INTO TWO
            var midPoint = numbers.Count / 2;
            var left = new List<int>(midPoint);
            var right = new List<int>(midPoint);
            for (var i = 0; i < midPoint; i++) left.Add(numbers[i]);
            for (var i = midPoint; i < numbers.Count; i++) right.Add(numbers[i]);

            // 2. RECURSIVELY BREAK DOWN THE ARRAYS
            left = MergeSort.Run(left);
            right = MergeSort.Run(right);

            // 3. MERGE THE ARRAYS
            var result = new List<int>(numbers.Count);
            while (left.Any() || right.Any())
            {
                if (left.Any() && right.Any())
                {
                    if (left.First() <= right.First())
                    {
                        var firstLeft = left.First();
                        result.Add(firstLeft);
                        left.Remove(firstLeft);
                    }
                    else
                    {
                        var firstRight = right.First();
                        result.Add(firstRight);
                        right.Remove(firstRight);
                    }
                }
                else if (left.Any())
                {
                    var firstLeft = left.First();
                    result.Add(firstLeft);
                    left.Remove(firstLeft);
                }
                else if (right.Any())
                {
                    var firstRight = right.First();
                    result.Add(firstRight);
                    right.Remove(firstRight);
                }
            }
            return result;
        }
    }
}