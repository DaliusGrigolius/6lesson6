using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD1_4
{
    internal class KmiCalculator
    {
        public decimal CalculateKmi(decimal height, decimal bodyMass)
        {
            return bodyMass / (height * height);
        }
    }
}
