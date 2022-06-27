using System;

namespace OneArgCalculator
{
    public class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Cos(value);
        }
    }
}
