using System;

namespace OneArgCalculator
{
    public class ModuleCalculator : IOneArgumentCalculator
    {
        public double Calculate(double value)
        {
            return Math.Abs(value);
        }
    }
}
