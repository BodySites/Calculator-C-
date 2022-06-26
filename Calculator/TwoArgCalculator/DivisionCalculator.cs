namespace TwoArgCalculator
{
    internal class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (secondValue != 0) ? firstValue / secondValue : -1;
        }
    }
}
