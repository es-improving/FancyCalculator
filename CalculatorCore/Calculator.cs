using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class Calculator
    {
        public EvaluationResult Evaluate(string input)
        {
            string[] expressionBits = input.Split(" ");

            decimal firstOperand = 0m;
            decimal secondOperand = 0m;

            if (decimal.TryParse(expressionBits[0], out firstOperand) == false)
            {
                return new EvaluationResult { ErrorMessage = $"The first number, '{expressionBits[0]}', was not a valid number." };
            }
            if (decimal.TryParse(expressionBits[2], out secondOperand) == false)
            {
                return new EvaluationResult { ErrorMessage = $"The second number, '{expressionBits[2]}', was not a valid number." };
            }

            return new EvaluationResult { Result = firstOperand + secondOperand };
        }
    }
}
