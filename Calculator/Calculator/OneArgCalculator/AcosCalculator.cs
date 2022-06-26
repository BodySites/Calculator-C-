using System;

namespace OneArgCalculator
{
    internal class AcosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Acos(value);
        }
    }
}
