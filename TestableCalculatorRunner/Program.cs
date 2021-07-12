using CalculatorCore;
using System;

namespace TestableCalculatorRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine("Give me math or give me death!");
            string input = Console.ReadLine();

            var output = calculator.Evaluate(input);

            if (String.IsNullOrWhiteSpace(output.ErrorMessage))
            {
                Console.WriteLine(output.Result);
            }
            else
            {
                Console.WriteLine("\u001b[31m" + output.ErrorMessage + "\u001b[0m");
            }
        }
    }
}
