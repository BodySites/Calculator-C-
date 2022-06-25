using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Cos(value);
        }
    }
}
