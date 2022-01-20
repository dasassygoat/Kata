using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    internal class LeastCommonMultiple_rewrite
    {
        public int Lcm(List<int> num)
        {
            if (num.Count == 0)
            {
                Console.WriteLine(1);
                return 1;
            }

            if (num.Count == 1)
            {
                Console.WriteLine(num.First());
                return num.First();
            }

            if(num.Count == 2)
            {
                var numListMultipled = (num[0] * num[1]) / Gcd(num);
                Console.WriteLine(numListMultipled);
                return numListMultipled;
            }  
            
            //Lcm(a,b) = (a X b) / Gcd(a,b)

            return 0;
        }

        public int Gcd(List<int> num)
        {
            //a = bq + r where 0 ≤ r < b;

            //if
            //  b > a
            //then
            //  b = a * 
            return 6;
        }
    }
}
