using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class ModuleTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double value = 38.44;
            double resultValue = Math.Abs(value);

            ModuleCalculator calculator = new ModuleCalculator();
            double actualResult = calculator.Calculate(value);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
