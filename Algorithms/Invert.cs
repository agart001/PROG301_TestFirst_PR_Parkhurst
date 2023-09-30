using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Invert
    {
        public int invertInt(int n)
        {
            int solution = 0;

            while (n > 0)
            {
                solution = solution * 10 + n % 10;
                n = n / 10;
            }          

            return solution;
        }
    }
}
