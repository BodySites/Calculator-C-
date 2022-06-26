using System;

namespace TwoArgCalculator
{
    internal class TwoArgumentsFactory
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
                case "step":
                    return new StepCalculator();
                case "degree":
                    return new DegreeCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
