

using DSA;
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
                        ReplaceString replaceString = new ReplaceString();
                        replaceString.StringReplace();
                        break;
                    case 3:
                        InsertionSort insertionsort = new InsertionSort();
                        Console.WriteLine("Enter limitation:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter strings:");
                        string[] a = new string[n];
                        for (int i = 0; i < n; i++)
                        {
                            a[i] = Console.ReadLine();
                        }
                        insertionsort.InsertionSorting(a);
                        Console.WriteLine("Array is sorted using insertion sort:");
                        insertionsort.Display(a);
                        break;
                    case 4:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.SortingBubble();
                        break;
                     case 5:
                        PrimeNumbers primeNumber = new PrimeNumbers();
                        Console.WriteLine("\nEnter a number :");
                        primeNumber.CheckPrime();
                        break;


                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}
