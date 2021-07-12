using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorCore.Tests
{
    [TestClass]
    public class CalculatorCoreTests
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            // arrange
            var calc = new Calculator();

            // act
            EvaluationResult result = calc.Evaluate("6 + 8");
            
            // assert
            Assert.AreEqual(14m, result.Result);
        }
    }
}
