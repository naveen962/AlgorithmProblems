using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BUBBLE SORT");
            int[]a = { 36, 19, 29, 12, 74, 6 };

            for(int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length ; j++)
                {
                    if (a[j] < a[i])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }

            }
            Console.WriteLine("Array after sorting");
            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + " ");
            }

        }
    }
}
