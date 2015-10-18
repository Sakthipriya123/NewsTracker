using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharpDay4.Test
{
    [TestClass]
    public class MathUtilityTest
    {
        [TestMethod]
        public void TestAddNumbers()    
        {
            //Arrange
            var math = new MathUtility();

            //Act

            var result = math.AddNumbers(0, 0);
            //Assert

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestAddOneAndOne()
        {
            //Arrange
            var math = new MathUtility();

            //Act

            var result = math.AddNumbers(1, 1);//becos we did multiplication in math utility
            //Assert

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestNegative()
        {
            //Arrange
            var math = new MathUtility();

            //Act

            var result = math.AddNumbers(int.MaxValue, int.MinValue);//becos we did multiplication in math utility
            //Assert

            Assert.AreEqual(int.MaxValue, result);
        }


    }
}
