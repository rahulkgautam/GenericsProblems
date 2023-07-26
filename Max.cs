using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsProblem
{
    class Max
    {
        public static void FindMax(int first, int second, int third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine("First is max {0}",first);
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine("Second is max {0}", second);
            else
                Console.WriteLine("Third is max {0}", third);
        }
    }
}
