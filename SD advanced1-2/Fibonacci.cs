using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_advanced1_2
{
    internal class Fibonacci
    {
        //public long GetFibSeriesNumSum(long number)
        //{
        //    if (number <= 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return GetFibSeriesNumSum(number - 2) + GetFibSeriesNumSum(number - 1);
        //    }

            //int p = 0;
            //int q = 1;

            //for (int i = 0; i < n; i++)
            //{
            //    int temp = p;
            //    p = q;
            //    q = temp + q;
            //}

            //return p;
        //}

        public long Fib(int n)
        {
            Dictionary<int, long> _memo = new() { { 0, 0 }, { 1, 1 } };

            if (_memo.ContainsKey(n))
                return _memo[n];

            var value = Fib(n - 1) + Fib(n - 2);

            _memo[n] = value;

            return value;
        }
    }
}
