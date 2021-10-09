using System;

namespace InserstionSortGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Insertion Sort");
            Insertion<string> insertionsort = new Insertion<string>();
            string[] a = { "Rahul", "abhi", "Martin", "billy", "sujesh" };
           
            insertionsort.Sort(a);
            
        }
    }
}
