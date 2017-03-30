using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCalcDomainLogic;
namespace WebCalcTests
{
    [TestClass]
    public class WebCalculatorTest
    {
        [TestMethod]
        public void AddNumbersShouldReturnTen()
        {
            WebCalculator calc = new WebCalculator();
            int result = calc.AddNumbers(8, 2);
            Assert.AreEqual(10, result);
        }
    }
}
