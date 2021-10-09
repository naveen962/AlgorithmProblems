using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string arg = "Welcome to tech hub India";
            var arr = arg.Split(" ");
            Console.WriteLine("Enter word to search");
            string word = Console.ReadLine();
            Search bs = new Search(arr, word);
            bs.BinarySearch(0, arr.Length - 1);
        }
    }
}
