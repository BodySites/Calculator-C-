using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneArgCalculator;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class AcosTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double value = 1.0;
            double resultValue = Math.Acos(value);

            AcosCalculator calculator = new AcosCalculator();
            double actualResult = calculator.Calculate(value);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
