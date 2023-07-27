using System;

namespace GenericsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 112, 344, 433, 555, 748, 232 };
            GenericsMaximum<int> generics = new GenericsMaximum<int>(arr);
            generics.PrintMaxValue();
        }
    }
}
