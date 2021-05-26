using System.Collections.Generic;

namespace SortingData
{
    public static class QuickSort
    {
        public static void Run(List<int>numbers, int firstItemIndex, int lastItemIndex)
        {
            if (firstItemIndex < lastItemIndex)
            {
                // calculate the split point
                var pivotIndex = Partition(numbers, firstItemIndex, lastItemIndex);

                // sort the two partitions
                QuickSort.Run(numbers, firstItemIndex, pivotIndex - 1);
                QuickSort.Run(numbers, pivotIndex + 1, lastItemIndex);
            }

        }

        public static int Partition(List<int> numbers, int first, int last)
        {
            // choose the first item as the pivot value
            var pivotValue = numbers[first];

            // establish the upper and lower indexes
            var lowerIndex = first + 1;
            var upperIndex = last;

            var done = false;
            while (!done)
            {
                // advance the lower index forward until it either crosses the
                // upper index or finds a value greater than the pivot value
                while (lowerIndex <= upperIndex
                       && numbers[lowerIndex] <= pivotValue)
                    lowerIndex += 1;

                // advance the upper index backward until it either crosses the
                // lower index or finds a value smaller than the pivot value
                while (upperIndex >= lowerIndex
                       && numbers[upperIndex] >= pivotValue)
                    upperIndex -= 1;

                // if the two indexes cross, we have found the split point
                if (upperIndex < lowerIndex)
                {
                    done = true;
                }
                // if not, switch the value the lower index points at with the
                // one that the upper index does. We know to do this because the
                // indexes have stopped moving at this point but they didn't
                // cross each other, indicating that they've found values
                // greater than and lesser than the pivot value respectively
                else
                {
                    var temp1 = numbers[lowerIndex];
                    numbers[lowerIndex] = numbers[upperIndex];
                    numbers[upperIndex] = temp1;
                }
            }

            // when the split point is found, exchange the position of the pivot
            // value with
            var temp2 = numbers[first];
            numbers[first] = numbers[upperIndex];
            numbers[upperIndex] = temp2;

            // return the split point index
            return upperIndex;
        }

    }
}