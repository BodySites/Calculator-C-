using System;

namespace OneArgCalculator
{
    public class AsinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Asin(value);
        }
    }
}
