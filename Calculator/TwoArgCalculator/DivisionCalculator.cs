namespace TwoArgCalculator
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (secondValue != 0) ? firstValue / secondValue : -1;
        }
    }
}
