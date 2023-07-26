using System;

namespace GenericsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //TC_!
            //string firstString = "xyz";
            //string secondString = "abc";
            //string thirdString = "def";

            //TC_2
            //string firstString = "abc";
            //string secondString = "xyz";
            //string thirdString = "def";

            //TC_3
            string firstString = "abc";
            string secondString = "def";
            string thirdString = "xyz";
            Max.FindMax(firstString, secondString, thirdString);
            
        }
    }
}
