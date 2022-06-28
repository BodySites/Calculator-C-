using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class DelTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            double value = 38.44;
            double resultValue = (1/value);

            DelCalculator calculator = new DelCalculator();
            double actualResult = calculator.Calculate(value);

            Assert.AreEqual(resultValue, actualResult);
        }
    }
}
