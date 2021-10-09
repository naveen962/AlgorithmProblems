using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchGenerics
{
    class Search<T> where T : IComparable
    {
       
       
        public void BinarySearch(List<T>wordList)
        {
            int startIndex = 0;
            int endIndex =wordList.Count-1;
            int midIndex = (startIndex + endIndex) / 2;
            Console.WriteLine("Enter the word to search");
            string word = Console.ReadLine();
            while (startIndex <= endIndex)
            {
                if (wordList[midIndex].Equals(word))
                {
                    Console.WriteLine("{0} found", word);
                    break;
                }
                else if (wordList[midIndex].CompareTo(word) < 0)
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    endIndex = midIndex - 1;
                }
                midIndex = (startIndex + endIndex) / 2;
            }
            if (startIndex > endIndex)
            {
                Console.WriteLine("Element not found");
            }

        }

    }
}
