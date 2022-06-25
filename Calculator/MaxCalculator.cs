using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MaxCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}
