using System.Collections.Generic;
using System.Linq;

namespace Miscellaneous
{
    /// <summary>
    /// Unique filtering with dictionary.
    /// </summary>
    public static class UniqueFiltering
    {
        public static List<T> Run<T>(IEnumerable<T> items)
        {
            var result = new List<T>();
            foreach (var item in items)
                if (!result.Contains(item))
                    result.Add(item);
            return result;
        }
    }
}