using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string CalculatorName)
        {
            switch (CalculatorName)
            {
                case "module":
                    return new ModuleCalculator();
                case "sin":
                    return new SinCalculator();
                case "cos":
                    return new CosCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
