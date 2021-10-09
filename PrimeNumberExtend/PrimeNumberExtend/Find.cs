using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumberExtend
{
    class Find
    {
       
        public static void Prime(int n)
        {
            int temp = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    temp = temp + 1;
                }
       
            }
            if (temp == 0)
            {
                Console.WriteLine(n + " is a Prime Number");

            }
            else
            {
                Console.WriteLine(n + " is not a Prime Number");
            }
        }
        public static void Palindrome(int n)
        {
            int rev = 0;
            int orno = n;
            while (n > 0)
            {
                int r = n % 10;
                n = n / 10;
                rev = rev * 10 + r;

            }
            if (orno == rev)
            {
                Console.WriteLine(orno + " is palindrome");

            }
            else
            {
                Console.WriteLine(orno + " Not a palindrome");
            }

        }

        public static void Anagram(string n1,string n2)
        {
            char[] s1 = n1.ToCharArray();
            char[] s2 = n2.ToCharArray();

            Array.Sort(s1);
            Array.Sort(s2);

            string val1 = new string(s1);
            string val2 = new string(s2);
            if (val1 == val2)
            {
                Console.WriteLine("This is Anagram");
                
            }
            else
            {
                Console.WriteLine("This is not Anagram");
               
            }
        }
    }
}
