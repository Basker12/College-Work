using System;
using System.Collections.Immutable;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] {10, 20, 30, 40, 50};
            var index = BinarySearch(arr, 30); //Here you assign the value that you're searching for
            Console.WriteLine("Element found at {0}", index);
        }

        public static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == key) return mid;
                else if (arr[mid] > key)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
