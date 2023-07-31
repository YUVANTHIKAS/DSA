

using System;
using System.Security.Cryptography.X509Certificates;

namespace DataStucturesAlgorithm
{
    class Program
    {
        static string searchFilePath = @"D:\DataStucturesAlgorithm\Files\Search.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option to execute \n 1.Binary Search  \n 2.ReplaceString \n 3. InsertionSort \n 4.BubbleSort \n 5. PrimeNumbers \n 6.Print Prime Numbers between 0 and 1000\n 7.Print Prime Numbers that are Anagram and Palindrome \n 8.Merge Sort");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {

                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.ReadTextFileAndSearch(searchFilePath);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
