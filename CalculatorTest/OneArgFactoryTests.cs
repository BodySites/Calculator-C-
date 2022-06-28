using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneArgCalculator;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class OneArgFactoryTests
    {
        [TestMethod]
        public void CreateCalculatorTest()
        {
            string name = "acos";
            Type type = typeof(AcosCalculator);

            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOfType(calculator, type);
        }
    }
}
