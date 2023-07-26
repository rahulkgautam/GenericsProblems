using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsProblem
{
    class Max<T> where T : IComparable<T>
    {
        public static void FindMax(T first, T second, T third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine("{0} is max ",first);
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine("{0} is max ", second);
            else
                Console.WriteLine("{0} is max ", third);
        }
    }
}
