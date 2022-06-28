using System;

namespace OneArgCalculator
{
    public class AcosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Acos(value);
        }
    }
}
