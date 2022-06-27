using System;

namespace TwoArgCalculator
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string CalculatorName)
        {
            switch (CalculatorName)
            {
                case "addition":
                    return new AdditionCalculator();
                case "division":
                    return new DivisionCalculator();
                case "multiply":
                    return new MultiplyCalculator();
                case "subtraction":
                    return new SubtractionCalculator();
                case "searchMin":
                    return new MinCalculator();
                case "searchMax":
                    return new MaxCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
