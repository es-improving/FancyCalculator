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

            string output = calculator.Evaluate(input);
            Console.WriteLine(output);
        }
    }
}
