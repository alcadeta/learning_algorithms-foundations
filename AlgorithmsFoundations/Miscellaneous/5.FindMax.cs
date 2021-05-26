using System;
using System.Collections.Generic;
using System.Linq;

namespace Miscellaneous
{
    public class FindMax
    {
        public static int Run(List<int> items)
        {
            // last item in the list? return it
            if (items.Count == 1) return items[0];

            // otherwise, get the first item and call function
            // again to operate on the rest of the list
            var op1 = items[0];
            Console.WriteLine(op1);
            var op2 = Run(items.Skip(1).ToList());
            Console.WriteLine(op2);

            // perform the comparison when we're down to just two
            return op1 >= op2 ? op1 : op2;
        }
    }
}