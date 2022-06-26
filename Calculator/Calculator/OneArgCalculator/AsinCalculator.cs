using System;

namespace OneArgCalculator
{
    internal class AsinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Asin(value);
        }
    }
}
