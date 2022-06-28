using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TwoArgCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class TwoArgsFactoryTests
    {
        [TestMethod]
        public void CreateCalculatorTest()
        {
            string name = "division";
            Type type = typeof(DivisionCalculator);

            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOfType(calculator, type);
        }
    }
}
