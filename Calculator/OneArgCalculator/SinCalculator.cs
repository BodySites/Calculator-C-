using System;

namespace OneArgCalculator
{
    public class SinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Sin(value);
        }
    }
}
