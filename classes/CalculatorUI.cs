using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CalculatorRPN;
    public class CalculatorUI : ICalculatorUI
    {
        public void DisplayOutput(string output)
        {
            Console.WriteLine(output);
        }

        public string GetInput()
        {
            try
            {
                string? input = Console.ReadLine();

                if (input == "+" || input == "-" || input == "/" || input == "*" || input == "q" || input == "c"|| double.TryParse(input, out _))
                {
                    return input;
                }
                else
                {
                    throw new Exception("This is not a valid input. Try again.");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetInput(); // Prompt for input again
            }
        }
    }
