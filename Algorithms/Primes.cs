using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Primes
    {
        public bool checkifPrime(int n)
        {
            //we know that 1 is not prime
            if (n == 1) return false;
            
            //we now need to find how many factors n has
            //cycle through all the possable factors in n
            //if n's factors is greater than 2 it is not prime
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public int LargestPrime(int n)
        {
            int largest = 0;

            //for all the possable prime factors cycle through and find the largest
            if(checkifPrime(n))
            {
                return n;
            }
            else
            {
                List<int> factors = new List<int>();
                for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        if(checkifPrime(i)) factors.Add(i);
                    }
                }

                largest = factors.Max();
            }
            

            return largest;
        }

        public int sumOfAllPrime(int n)
        {
            int sum = 0;

            //cycle through all the numbers of n and check if its prime if it is then add to total
            for (int i = 1; i < n; i++)
            {
                if (checkifPrime(i)) sum += i;
            }

            
            return sum;
        }
    }
}
