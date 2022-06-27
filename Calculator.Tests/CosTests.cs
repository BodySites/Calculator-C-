using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class CosTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double value = 38.44;
            double resultValue = Math.Cos(value);

            CosCalculator calculator = new CosCalculator();
            double actualResult = calculator.Calculate(value);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
