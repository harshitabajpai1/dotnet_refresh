using CalculatorService;
namespace NUnitTestProject
{
    //[testfixture] is an attribute that marks a class as containing tests  
    public class Tests
    {
        Calculator calcObj = null; //delacred at class level
        [SetUp]
        public void Setup()
        {
            calcObj = new Calculator(); //initialized inside Setup method
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown]
        public void Reset()
        {
            calcObj = null; //cleaned up inside TearDown method
            //works like destructor
        }
    }
}
