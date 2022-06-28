using System;

namespace OneArgCalculator
{
    public class DelCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return 1/value;
        }
    }
}
