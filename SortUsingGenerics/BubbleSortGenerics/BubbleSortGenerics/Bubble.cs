using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSortGenerics
{
    class Bubble<T>where T:IComparable
    {
        public void Sort(T[] a )
        {
            Console.WriteLine("Before sorting");

            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("--------------------------------------");
            for (var i = 0; i < a.Length; i++)
            {
                for (var j = i; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[i])<0)
                    {
                        var temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }


            }
            Console.WriteLine("After sorting");
            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + " ");
            }

        }
    }
}
