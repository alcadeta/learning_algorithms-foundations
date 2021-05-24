using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SortingData
{
    public static class BubbleSort
    {
        public static void Run(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
                array.Dump($"Iteration #{i + 1}");
            }
        }
    }
}