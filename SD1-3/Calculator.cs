using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD1_3
{
    internal class Calculator
    {
        public long GetNumSum(long number)
        {
            long result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
