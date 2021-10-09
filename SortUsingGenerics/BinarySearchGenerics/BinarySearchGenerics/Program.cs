using System;
using System.Collections.Generic;

namespace BinarySearchGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string arg = "Welcome to tech hub India";
           
            List<string> words = new List<string>(arg.Split(" "));
            words.Sort();
            Search<string> bs = new Search<string>();
            bs.BinarySearch(words);

        }
    }
}
