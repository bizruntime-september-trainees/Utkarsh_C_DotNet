using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

using System;

namespace Calculator
{
    [TestClass]
    public class Test_calculate
    {
        [TestMethod]
        public void Test_Divide()
        {
            int expected = 5;
            

            int actual = Calculator.Calculate.Divide(100,20);

            Assert.AreEqual(expected, actual);
        }
    }
}
