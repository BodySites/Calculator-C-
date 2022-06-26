using System;

namespace OneArgCalculator
{
    internal class SinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Sin(value);
        }
    }
}
