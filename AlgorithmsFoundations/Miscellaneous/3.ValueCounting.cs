using System.Collections.Generic;

namespace Miscellaneous
{
    public class ValueCounting
    {
        public static Dictionary<T, int> Run<T>(IEnumerable<T> items)
        {
            var result = new Dictionary<T, int>();
            foreach (var item in items)
                if (result.ContainsKey(item))
                    result[item]++;
                else
                    result.Add(item, 1);
            return result;
        }
    }
}