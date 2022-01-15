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
            if (num.Count == 1)
            {
                Console.WriteLine(num.First());
                return num.First();
            }

            if (num.Count == 0)
            {
                Console.WriteLine(1);
                return 1;
            }
            return 0;
        }
    }
}
