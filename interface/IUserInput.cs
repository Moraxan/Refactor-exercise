using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorRPN
{
    public interface IUserInput
    {
        string GetInput();
        void DisplayOutput(string output);
    }
}