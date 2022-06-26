using System;

namespace TwoArgCalculator
{
    internal class DegreeCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, 1.0/secondValue);
        }
    }
}
