using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arrSample = { 8, 4, 23, 42, 16, 15 };
            insertSort(arrSample);
        }

        public static void insertSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while(j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;

                    arr[j + 1] = temp;
                }
            }
            Console.WriteLine(arr[5]);
        }
    }
}
