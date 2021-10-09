using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{


    class Search
    {
        private string[] strArr;
        private string word;
        public Search(string[] arr, string word)
        {
            this.strArr = arr;
            this.word = word;
            Array.Sort(this.strArr);
        }

        public void BinarySearch(int startIndex, int endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            while (startIndex <= endIndex)
            {
                if (strArr[midIndex].Equals(word))
                {
                    Console.WriteLine("{0} found", word);
                    break;
                }
                else if (strArr[midIndex].CompareTo(word) < 0)
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
