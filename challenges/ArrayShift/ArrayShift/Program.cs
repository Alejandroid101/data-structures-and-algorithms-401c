using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code Challenges for 401 ASP.NET!");

            int[] tryarr = { 1, 4, 7, 2, 6 };
            int trynumb = 15;
            Console.WriteLine(insertShiftArray(tryarr, trynumb));
        }

        public static Array insertShiftArray(int[] arr, int value)
        {
            int length = arr.Length +1;
            int[] newArr = new int[length];
            int midPoint;

            if(arr.Length % 2 == 0)
            {
                midPoint = arr.Length / 2;
            }
            else
            {
                int mid = arr.Length + 1;
                midPoint = mid / 2;
            }
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < midPoint)
                {
                    newArr[i] = arr[i];
                }
                else if(i == midPoint)
                {
                    newArr[i] = value;
                }
                else
                {
                    newArr[i] = arr[i - 1];
                }
                return newArr;
            }
            return newArr;
        }
    }
}
