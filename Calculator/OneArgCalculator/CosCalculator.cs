using System;

namespace OneArgCalculator
{
    internal class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Cos(value);
        }
    }
}
