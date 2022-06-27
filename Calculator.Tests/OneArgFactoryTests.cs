using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class OneArgFactoryTests
    {
        [TestMethod]
        public void CreateCalculatorTest()
        {
            string name = "cos";
            Type type = typeof(CosCalculator);

            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOfType(calculator, type);
        }
    }
}
