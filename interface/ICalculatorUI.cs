using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorRPN;
    public interface ICalculatorUI
    {
        string GetInput();
        void DisplayOutput(string output);
    }

