using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test_Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 5;

            int num = 20;
            int den = 4;

            int actual = Calculator.Program.Divide(num, den);

            Assert.AreEqual(expected, actual);


            

            
        }
    }
}
