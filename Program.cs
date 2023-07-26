using System;

namespace GenericsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //TC_!
            //int firstNumber = 40;
            //int secondNumber = 20;
            //int thirdNumber = 12;

            //TC_2
            //int firstNumber = 10;
            //int secondNumber = 20;
            //int thirdNumber = 12;

            //TC_3
            int firstNumber = 10;
            int secondNumber = 20;
            int thirdNumber = 30;
            Max<int>.FindMax(firstNumber, secondNumber, thirdNumber);

            //TC_!
            //float firstNumber = 40f;
            //float secondNumber = 20f;
            //float thirdNumber = 12f;

            //TC_2
            //float firstNumber = 10f;
            //float secondNumber = 20f;
            //float thirdNumber = 12f;

            //TC_3
            //float firstNumber = 10f;
            //float secondNumber = 20f;
            //float thirdNumber = 30f;
            //Max<float>.FindMax(firstNumber, secondNumber, thirdNumber);

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
            Max<string>.FindMax(firstString, secondString, thirdString);

        }
    }
}
