using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class MultiplyTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double firstValue = 38.44;
            double secondValue = 1.755;
            double resultValue = firstValue * secondValue;

            MultiplyCalculator calculator = new MultiplyCalculator();
            double actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
