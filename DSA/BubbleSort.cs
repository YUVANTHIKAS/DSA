using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class BubbleSort
    {
        public void SortingBubble()
        {
            Console.WriteLine("Enter limitation:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int t;
            for (int j = 0; j <= n - 2; j++)
            {
                for (int i = 0; i <= n - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (var item in a)
                Console.WriteLine(item + " ");
        }
    }
}
