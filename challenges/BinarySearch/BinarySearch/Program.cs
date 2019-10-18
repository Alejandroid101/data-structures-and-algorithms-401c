using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] one = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] two = { 8, 13, 27, 55, 57 };
            //int[] three = { 6, 66, 666, 6666 };
            //int[] four = { };
            int one1 = 3;
            //int two2 = 57;
            //int three3 = 69;
            //int four4 = 100;
            Console.WriteLine(BinarySearch(one, one1));

        }

        public static int BinarySearch(int[] arr, int value)
        {
            int len = arr.Length;
            int left = 0;
            int right = len - 1;
            while (left <= right)
            {
                int sum = left + right;
                int mp = sum / 2;
                if (arr[mp] < value)
                {
                    left = mp + 1;
                }
                else if(arr[mp] > value)
                {
                    right = mp - 1;
                }
                else
                {
                    return mp;
                }
            }
                return -1;
        }
    }
}
