using System;

namespace BubbleSortGenerics
{
    class Program
    {
         static void Main(string[] args)
         {
            Console.WriteLine("Welcome to BUBBLE SORT");
            int[] a = { 36, 19, 29, 12, 74, 6 };
            Bubble<int> bs = new Bubble<int>();
            bs.Sort(a);

                


              
         }
    }
}
    

