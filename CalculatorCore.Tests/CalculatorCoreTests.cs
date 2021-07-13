using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorCore.Tests
{
    [TestClass]
    public class CalculatorCoreTests
    {
        private Calculator _calc;

        [TestInitialize]
        public void Initialize()
        {
            _calc = new Calculator();
        }

        [TestMethod]
        public void AddTwoNumbers()
        {
            // act
            EvaluationResult result = _calc.Evaluate("6 + 8");
            
            // assert
            Assert.AreEqual(14m, result.Result);
        }

        [TestMethod]
        public void FirstOperandMustBeNumber()
        {
            var result = _calc.Evaluate("fdsalkj + 8");
            var wut = 2;
            Assert.AreEqual("The first number, 'fdsalkj', was not a valid number.", result.ErrorMessage);
        }

        [TestMethod]
        public void SecondOperandMustBeNumber()
        {
            var result = _calc.Evaluate("7 + hello");
            Assert.AreEqual("The second number, 'hello', was not a valid number.", result.ErrorMessage);
        }

        [TestMethod]
        public void SubtractANumberFromAnother()
        {
            var result = _calc.Evaluate("7 - 687");
            Assert.AreEqual(-680m, result.Result);
        }

        [TestMethod]
        public void DivisionWorks()
        {
            var result = _calc.Evaluate("8 / 4");
            Assert.AreEqual(2m, result.Result);
        }

        [TestMethod]
        public void MultiplicationWorks()
        {
            var result = _calc.Evaluate("2 * 12");
            Assert.AreEqual(24m, result.Result);
        }

        [TestMethod]
        public void DoesValidationOfOperator()
        {
            var result = _calc.Evaluate("80 minus 700");
            Assert.AreEqual("The operation 'minus' is invalid. You must use one of the following: + - * /", result.ErrorMessage);
        }

        [TestMethod]
        public void ComboOperatorIsCaught()
        {
            var result = _calc.Evaluate("2 -* 8");
            Assert.AreEqual("The operation '-*' is invalid. You must use one of the following: + - * /", result.ErrorMessage);
        }
    }
}
