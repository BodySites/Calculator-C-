using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class SinTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double value = 38.44;
            double resultValue = Math.Sin(value);

            SinCalculator calculator = new SinCalculator();
            double actualResult = calculator.Calculate(value);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
