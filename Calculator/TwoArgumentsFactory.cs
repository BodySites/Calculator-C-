using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
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
                case "exponentiation":
                    return new ExponentiationCalculator();
                case "square":
                    return new  SquareCalculator();
                case "remains":
                    return new  RemainsCalculator();                    
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
