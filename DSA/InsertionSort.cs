using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class InsertionSort
    {
        public void InsertionSorting(string[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; i++)
            {
                string t = a[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(a[j], t) > 0)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }

                a[j + 1] = t;
            }
        }

        public void Display(string[] a)
        {
            foreach (var item in a)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
