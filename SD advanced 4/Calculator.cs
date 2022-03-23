using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_advanced_4
{
    internal class Calculator
    {
        public long CalcFactorial(int number)
        {
            long num = 1;
            for (int i = 1; i <= number; i++)
            {
                num *= i;
            }
            return num;
        }
    }
}
