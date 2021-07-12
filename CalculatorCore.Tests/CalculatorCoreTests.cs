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

        [TestMethod]
        public void FirstOperandMustBeNumber()
        {
            var calc = new Calculator();
            var result = calc.Evaluate("fdsalkj + 8");
            Assert.AreEqual("The first number, 'fdsalkj', was not a valid number.", result.ErrorMessage);
        }

        [TestMethod]
        public void SecondOperandMustBeNumber()
        {
            var calc = new Calculator();
            var result = calc.Evaluate("7 + hello");
            Assert.AreEqual("The second number, 'hello', was not a valid number.", result.ErrorMessage);
        }

        [TestMethod]
        public void SubtractANumberFromAnother()
        {
            var calc = new Calculator();
            var result = calc.Evaluate("7 - 687");
            Assert.AreEqual(-680m, result.Result);
        }

        [TestMethod]
        public void DivisionWorks()
        {
            var calc = new Calculator();
            var result = calc.Evaluate("8 / 4");
            Assert.AreEqual(2m, result.Result);
        }

        [TestMethod]
        public void MultiplicationWorks()
        {
            var calc = new Calculator();
            var result = calc.Evaluate("2 * 12");
            Assert.AreEqual(24m, result.Result);
        }
    }
}
