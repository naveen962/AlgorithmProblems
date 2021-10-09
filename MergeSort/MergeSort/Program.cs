
using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To MERGE SORT");
            string[] arr = { "ram", "abhi", "billy","Martin","sachin", "virat" };
            Merge.Sort(arr, 0, arr.Length - 1);
            Merge.PrintArray(arr);
        }
    }
}
