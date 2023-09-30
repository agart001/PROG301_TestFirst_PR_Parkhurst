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
            if (n == 1 || n % 2 == 0) return false;
            if (n == 2) return true;
            
            //we now need to find how many factors n has
            //cycle through all the possable factors in n
            //if n's factors is greater than 2 it is not prime
            int max_factor = (int)Math.Sqrt(n);
            for (int i = 3; i <= max_factor; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public int LargestPrime(int n)
        {
            int largest = 0;

            //for all the possable prime factors cycle through and find the largest
            

            return largest;
        }

        public int sumOfAllPrime(int n)
        {
            int sum = 0;

            //cycle through all the numbers of n and check if its prime if it is then add to total
            
            return sum;
        }
    }
}
