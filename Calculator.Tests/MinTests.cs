using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class MinTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double firstValue = 38.44;
            double secondValue = 1.755;
            double resultValue = Math.Min(firstValue, secondValue);

            MinCalculator calculator = new MinCalculator();
            double actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
