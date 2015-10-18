using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharpReview;

namespace MathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddNumber()
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var answer = calculator.AddNumbers(2, 2);

            //Assert
            Assert.AreEqual(4, answer);


        }
    }
}
