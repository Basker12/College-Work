using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newList = {20, 60, 80, 10, 30, 70, 90, 100 };
            
            Console.WriteLine("Please write a number: ");
            int number = 30;

            foreach (var i in newList)
            {
                if (number == i)
                {
                    Console.WriteLine("Your number has been found" + i);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry your number hasn't been found.");
                }
            }
        }
    }
}