using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TwoArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class StepTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double firstValue = 38.44;
            double secondValue = 1.755;
            double resultValue = Math.Pow(firstValue, secondValue);

            StepCalculator calculator = new StepCalculator();
            double actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
