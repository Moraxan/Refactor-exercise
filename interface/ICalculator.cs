using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorRPN;
    public interface ICalculator
    {
        void Push(double value);
        double Pop();
        double Peek();
        void Add();
        void Subtract();
        void Multiply();
        void Divide();
        void Clear();
    }

