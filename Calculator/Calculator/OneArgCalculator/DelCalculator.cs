using System;

namespace OneArgCalculator
{
    internal class DelCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return 1/value;
        }
    }
}
