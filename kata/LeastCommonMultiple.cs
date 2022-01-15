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
            var startingValue = 1;
            for (int x =1;x <= num.Count;x++) 
            {
                
                Console.WriteLine($"Staring Value: {startingValue}");
                var multiple = num[x-1];
                Console.WriteLine($"Multiple Value: {multiple}");
                bool notFound = true;
                while (notFound)
                {
                    
                    int foundValue = 0;
                    foundValue = num.Count(v => (v * startingValue) == multiple);
                    if(foundValue > 1)
                    {
                        Console.WriteLine($"Found multiple {multiple} and startingValue: {startingValue}");
                        notFound = false;
                    }

                  startingValue = startingValue + 1;  
                }
                
            }
            return 0;
        }
    }
}
