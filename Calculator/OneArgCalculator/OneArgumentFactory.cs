using System;

namespace OneArgCalculator
{
    public class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string CalculatorName)
        {
            switch (CalculatorName)
            {
                case "del":
                    return new DelCalculator();
                case "asin":
                    return new AsinCalculator();
                case "acos":
                    return new AcosCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
