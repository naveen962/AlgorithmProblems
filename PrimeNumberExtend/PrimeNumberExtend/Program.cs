using System;

namespace PrimeNumberExtend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the First Number");
            int n2 = int.Parse(Console.ReadLine());
            Find.Prime(n1);
            Find.Prime(n2);
            Find.Palindrome(n1);
            Find.Palindrome(n2);
            Find.Anagram(Convert.ToString(n1), Convert.ToString(n2));

        }
    }
}
      
