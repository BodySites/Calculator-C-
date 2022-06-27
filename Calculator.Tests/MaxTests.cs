using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class MaxTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double firstValue = 38.44;
            double secondValue = 1.755;
            double resultValue = Math.Max(firstValue, secondValue);

            MaxCalculator calculator = new MaxCalculator();
            double actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
