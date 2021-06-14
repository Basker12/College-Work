using System;
using System.Collections;
using System.Collections.Generic;

namespace RPN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contents = {"5", "5", "+", "5", "5", "+", "+" }; // The equation that you wants to be done
            int results = RPNSolved(contents);
            Console.WriteLine(results); // This writes out the answer
            Console.ReadKey();
        }

        static int RPNSolved(string[] contents)
        {
            var R = new Stack<int>(); // A stack is a data structure
            int val1, val2; // This takes the two values e.g. 5, 5

            for (int iCounter = 0; iCounter < contents.Length; iCounter++)
            {
                switch (contents[iCounter])
                {
                    case "+":
                        val1 = R.Pop(); // When you pop you're getting rid of the value at the top
                        val2 = R.Pop();
                        R.Push(val1 + val2);
                        break;
                    
                    case "-":
                        val1 = R.Pop();
                        val2 = R.Pop();
                        R.Push(val1 - val2);
                        break;
                    
                    case "*":
                        val1 = R.Pop();
                        val2 = R.Pop();
                        R.Push(val1 * val2);
                        break;
                    
                    case "/":
                        val1 = R.Pop();
                        val2 = R.Pop();
                        R.Push(val1 / val2);
                        break;
                    
                    default:
                        R.Push(Convert.ToInt32(contents[iCounter])); // This pushes all the values to the stack
                        break;

                }
            }

            return R.Pop();
        }
    }
}
