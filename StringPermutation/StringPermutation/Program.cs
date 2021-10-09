using System;

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to STRING PERMUTATIONS");
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            int n = s.Length;
            Permutation.Permute(s, 0, n - 1);
        }
    }
}
