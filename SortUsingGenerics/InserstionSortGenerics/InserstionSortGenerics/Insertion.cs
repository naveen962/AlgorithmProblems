using System;
using System.Collections.Generic;
using System.Text;

namespace InserstionSortGenerics
{
    class Insertion<T>where T:IComparable
    {
        public void Sort(T[] a)
        {
            Console.WriteLine("Before Sorting");
            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            T temp ;
            int j;

            for (int i = 1; i <= a.Length - 1; i++)
            {
                temp = a[i];
                j = i;
                while (j > 0 && a[j - 1].CompareTo(temp) > 0)
                {
                    a[j] = a[j - 1];
                    j = j - 1;
                }
                a[j] = temp;
            }
            Console.WriteLine("After Sorting");
            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
        }
    }
    
    
}
