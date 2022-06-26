namespace TwoArgCalculator
{
    internal class AdditionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
