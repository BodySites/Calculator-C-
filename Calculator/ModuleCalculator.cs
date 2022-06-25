using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class ModuleCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Abs(value);
        }
    }
}
