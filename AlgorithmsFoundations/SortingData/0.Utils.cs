using System;
using Newtonsoft.Json;

namespace SortingData
{
    public static class Utils
    {
        public static void Dump(this object self, string label = null)
        {
            if (label is not null) Console.Write(label + ": ");
            Console.Write(JsonConvert.SerializeObject(self) + "\n");
        }
    }
}