using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsProblem
{
    class GenericsMaximum<T> where T : IComparable<T>
    {
        public T[] value;
       
        public GenericsMaximum(T[] value)
        {
            this.value = value;            
        }
        public T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is "+max);
        }
        
        
    }
}
