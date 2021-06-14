using System;
using System.Collections;
using System.Collections.Generic;

namespace RPN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contents = {"5", "5", "+", "5", "5", "+", "+" };
            int results = RPNSolved(contents);
            Console.WriteLine(results);
            Console.ReadKey();
        }

        static int RPNSolved(string[] contents)
        {
            var R = new Stack<int>();
            int val1, val2;

            for (int iCounter = 0; iCounter < contents.Length; iCounter++)
            {
                switch (contents[iCounter])
                {
                    case "+":
                        val1 = R.Pop();
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
                        R.Push(Convert.ToInt32(contents[iCounter]));
                        break;

                }
            }

            return R.Pop();
        }
    }
}