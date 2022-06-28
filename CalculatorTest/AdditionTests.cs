using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double firstValue = 8.4;
            double secondValue = 2.0;
            double resultValue = firstValue + secondValue;

            AdditionCalculator calculator = new AdditionCalculator();
            double actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
