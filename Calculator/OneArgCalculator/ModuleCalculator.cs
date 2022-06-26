using System;

namespace OneArgCalculator
{
    internal class ModuleCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Abs(value);
        }
    }
}
