using System;

namespace TwoArgCalculator
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (secondValue != 0) ? 
                firstValue / secondValue : throw new Exception("Деление на 0");
        }
    }
}
