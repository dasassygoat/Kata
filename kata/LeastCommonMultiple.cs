using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    internal class LeastCommonMultiple
    {
        //Write a function that calculates the least common multiple of its arguments; each argument is assumed to be a non-negative integer.In the case that there are no arguments (or the provided array in compiled languages is empty), return 1.

        public int Lcm(List<int> num)
        {
            if(num.Count == 1)
            {
                Console.WriteLine(num.First());
                return num.First();
            }

            if (num.Count == 0)
            {
                Console.WriteLine(1);
                return 1;
            }

            int lcmValue = 0;
            for(int x =1;x <= num.Count;x++) 
            {
                var startingValue =1;

                while (true)
                {
                    var multiple = num[x] * startingValue;
                    int foundValue = 0;
                    foundValue = num.Count(x => (x * startingValue) == multiple);
                    if(foundValue > 1)
                    {
                        Console.WriteLine("Found multiple");
                        break;
                    }

                    startingValue = startingValue + 1;
                }
            }
            return 0;
        }
    }
}
