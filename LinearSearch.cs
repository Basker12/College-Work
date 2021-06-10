using System;

namespace LinearSearch2
{
    class LinearSearch
    {
        static void Main(string[] args)
        {
            int[] newList = {10, 30, 50, 20, 40, 60, 90, 100};
            int number = 60;

            foreach (var i in newList)
            {
                if (number == i) //This linear search goes through every single value in the list and checks if it's the same as the user input.
                {
                    Console.WriteLine("Oh, here is your number " + i);
                    break;
                }
                else
                {
                    Console.WriteLine("Still searching...");
                }
            }
            {
                
            }
        }
    }
}
