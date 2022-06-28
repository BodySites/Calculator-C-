using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TwoArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class DegreeTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double firstValue = 8.0;
            double secondValue = 3.0;
            double resultValue = Math.Pow(firstValue, 1.0/secondValue);

            DegreeCalculator calculator = new DegreeCalculator();
            double actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
