using System;

namespace OneArgCalculator
{
    public class OneArgumentFactory
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
