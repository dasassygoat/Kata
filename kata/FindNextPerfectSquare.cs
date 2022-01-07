using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    internal class FindNextPerfectSquare
    {
        public long findNextSquare(long num)
        {
            long nextSquare = 0;

            double previousSquaredInteger = 0;
            
            previousSquaredInteger = Math.Sqrt(num);

            if ( previousSquaredInteger % 1 != 0)
            {
                Console.WriteLine(-1);
                return -1;
            }
            else
            {
                nextSquare = (long) Math.Pow(previousSquaredInteger + 1, 2);
                Console.WriteLine(nextSquare);
                return nextSquare;
            }
        }
    }
}
