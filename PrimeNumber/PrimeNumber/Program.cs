using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int i, j;
            int temp = 0;

            for ( i = 2; i < n; i++)
            { 

                for (j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        temp = temp + 1;
                        break;
                    }
                }
                if (temp == 0)
                {
                  Console.WriteLine(i);
                }
                else
                {
                   temp = 0;
                }
            }
                
            
        }
    }
}
