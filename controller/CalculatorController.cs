using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorRPN;
    public class CalculatorController
    {
        private readonly ICalculator? calculator;
        private readonly ICalculatorUI? calculatorUI;

            public CalculatorController (ICalculator calculator, ICalculatorUI calculatorUI)
            {
                this.calculator = calculator;
                this.calculatorUI = calculatorUI;
            }

            public void Run()
        {
            Stack<double> stack = new Stack<double>();
            while (true)
            {
                // Display UI and handle user input
                string input = calculatorUI?.GetInput();

                // Process input using the calculator interface methods
                // For example:
                // if (Char.IsDigit(command))
                // {
                //     double value = Convert.ToDouble(input);
                //     calculator.Push(value);
                // }

                // Display output using the calculator UI
                calculatorUI?.DisplayOutput(stack.ToString());
            }
        }
    }
