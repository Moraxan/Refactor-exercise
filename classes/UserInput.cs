using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorRPN
{
    public class UserInput : IUserInput
    {
        public void DisplayOutput(string output)
        {
            Console.WriteLine(output);
        }

        public string GetInput()
        {
            try
            {
                string input = Console.ReadLine();

                if (input == "+" || input == "-" || input == "/" || input == "*" || input == "q" || input == "c")
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
}