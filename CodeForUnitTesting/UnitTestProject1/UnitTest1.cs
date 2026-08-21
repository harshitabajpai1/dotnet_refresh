using Microsoft.VisualStudio.TestTools.UnitTesting;   //declares the attributes and classes for unit testing
using System;
using CalculatorService;

namespace UnitTestProject1
{
    [TestClass] //indicates that this class contains unit tests
    //serialization attribute on the class and non serializqation on the field
    public class UnitTest1
    {
        Calculator calc = null; //instance of the class to be tested
        public UnitTest1()
        {
            calc = new Calculator(); //initializing the instance
        }
        [TestMethod]
        public void TestMethodForAddMe()    //all methods are generelly public void and have no parameters
        {
            int numTest1 = 100;
            int numTest2 = 20;
            int actual = 0;
            int expected = 300;
            actual = calc.AddMe(numTest1, numTest2); //calling the method to be tested


            Assert.AreEqual(expected, actual); //asserting the expected and actual results
        }
    }
}
