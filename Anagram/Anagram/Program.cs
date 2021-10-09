using System;

namespace Anagram
{
    class Program
    {

        public bool Anagram(string word1,string word2)
        {
            char[] s1 = word1.ToCharArray();
            char[] s2 = word2.ToCharArray();

            Array.Sort(s1);
            Array.Sort(s2);

            string val1 = new string(s1);
            string val2 = new string(s2);
            if (val1 == val2)
            {
                Console.WriteLine("This is Anagram");
                return true;
            }
            else
            {
                Console.WriteLine("This is not Anagram");
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word");
            string w1 = Console.ReadLine();

            Console.WriteLine("Enter the second word");
            string w2 = Console.ReadLine();

            Program p = new Program();
            Console.WriteLine(p.Anagram(w1,w2));
        }
    }
}
