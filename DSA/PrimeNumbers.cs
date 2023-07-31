using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class PrimeNumbers
    {
        public void CheckPrime()
        {
            Console.WriteLine("Prime numbers from 0 to 1000:");
            for (int n = 2; n <= 1000; n++)
            {
                bool isPrime = true;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(n + " ");
                }
            }
        }
    }
}
