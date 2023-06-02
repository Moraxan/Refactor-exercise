using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorRPN
{
    public class Calculator : ICalculator
    {
         private Stack<double> stack;

    public Calculator()
    {
        stack = new Stack<double>();
    }

        public void Push(double value)
        {
            stack.Push(value);
        }

        public double Pop()
        {
            if (stack.Count > 0)
                return stack.Pop();

            Console.WriteLine("Stack empty, returning 0");
            return 0;
        }

        public double Peek()
        {
            if (stack.Count > 0)
                return stack.Peek();

            Console.WriteLine("Stack empty, returning 0");
            return 0;
        }
        public void Add()
        {
            stack.Push(stack.Pop() + stack.Pop());
        }

        public void Clear()
        {
             stack.Clear();
        }

        public void Divide()
        {
            double secondOperand = stack.Pop();
                    stack.Push(stack.Pop() / secondOperand);
        }

        public void Multiply()
        {
            stack.Push(stack.Pop() * stack.Pop());
        }

        public void Subtract()
        {
           double secondOperand = stack.Pop();
                    stack.Push(stack.Pop() - secondOperand);
        }
    }
}