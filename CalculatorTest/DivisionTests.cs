using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TwoArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double firstValue = 38.44;
            double secondValue = 1.755;
            double resultValue = firstValue / secondValue;

            DivisionCalculator calculator = new DivisionCalculator();
            double actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(resultValue, actualResult);
        }

        [TestMethod]
        public void ExceptionTest()
        {
            double firstValue = 38.44;
            double secondValue = 0;

            DivisionCalculator calculator = new DivisionCalculator();

            Assert.ThrowsException<Exception>(() => calculator.Calculate(firstValue, secondValue));
        }
    }
}
