using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Fibonacci
    {
        public int numberOfFib(int n)
        {
            int number = n - 1;
            int[] Fib = new int[number + 1];

            if (number < 0) return -1;

            if (number == 0 || number == 1) return 1;

            Fib[0] = 1;
            Fib[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 1] + Fib[i - 2];
            }

            return Fib[number - 1];
        }
    }
}
