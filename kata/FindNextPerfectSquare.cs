﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    internal class FindNextPerfectSquare
    {
        //You might know some pretty large perfect squares.But what about the NEXT one?

        //Complete the findNextSquare method that finds the next integral perfect square after the one passed as a parameter. Recall that an integral perfect square is an integer n such that sqrt(n) is also an integer.

        //If the parameter is itself not a perfect square then -1 should be returned.You may assume the parameter is non-negative.

        //Examples:(Input --> Output)

        //121 --> 144
        //625 --> 676
        //114 --> -1 since 114 is not a perfect square

        public double findNextSquare(double previousSquare)
        {
            double nextSquare = 0;

            double previousSquaredInteger = 0;
            
            previousSquaredInteger = Math.Sqrt(previousSquare);

            if ( previousSquaredInteger % 1 != 0)
            {
                Console.WriteLine(-1);
                return -1;
            }
            else
            {
                previousSquaredInteger = Math.Pow(previousSquaredInteger + 1, 2);
                Console.WriteLine(previousSquaredInteger);
                return previousSquaredInteger;
            }
        }
    }
}