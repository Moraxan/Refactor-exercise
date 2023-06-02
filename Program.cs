using System;
using System.Text;

namespace CalculatorRPN
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();
            ICalculatorUI calculatorUI = new CalculatorUI();
            CalculatorController controller = new CalculatorController(calculator, calculatorUI);

        controller.Run();
        }
    }
}
    //         CalculatorStack stack = new CalculatorStack();
    //         //I shouldn't need the while loop.
    //         while (true)
    //         {
    //             //This should be a switch I can rewrite the switch to use clean code later. 
    //             if (stack.Depth == 0)
    //             {
    //                 Console.WriteLine("Commands: q c + - * / number");
    //                 Console.WriteLine("[]");
    //             }
    //             else
    //             {
    //                 Console.WriteLine(stack.ToString());
    //             }
    //             string input = Console.ReadLine().Trim();
    //             if (input == "") input = " ";
    //             char command = input[0];
    //             if (Char.IsDigit(command))
    //             {
    //                 double value = Convert.ToDouble(input);
    //                 stack.Push(value);
    //             }
    //             else if (command == '+')
    //             {
    //                 stack.Push(stack.Pop() + stack.Pop());
    //             }
    //             else if (command == '*')
    //             {
    //                 stack.Push(stack.Pop() * stack.Pop());
    //             }
    //             else if (command == '-')
    //             {
    //                 double secondOperand = stack.Pop();
    //                 stack.Push(stack.Pop() - secondOperand);
    //             }
    //             else if (command == '/')
    //             {
    //                 double secondOperand = stack.Pop();
    //                 stack.Push(stack.Pop() / secondOperand);
    //             }
    //             else if (command == 'c')
    //             {
    //                 stack.Clear();
    //             }
    //             else if (command == 'q')
    //             {
    //                 break;
    //             }
    //             else
    //             {
    //                 Console.WriteLine("Illegal command, ignored");
    //             }

    //         }
    //     }
    // }
//This could be lifted out and renamed. What does Push, Pop and Peek do?
    // class CalculatorStack
    // {
    //     private double[]? data;
    //     public int Depth { get; private set; }

        // public void NewStack()
        // {
        //     data = new double[1000];
        //     Depth = 0;
        // }

        // public void Push(double value)
        // {
        //     data[Depth++] = value;
        // }

        // public double Pop()
        // {
        //     if (Depth > 0)
        //     {
        //         return data[--Depth];
        //     }
        //     else
        //     {
        //         Console.WriteLine("stack empty, returning 0");
        //         return 0;
        //     }
        // }

        // public double Peek()
        // {
        //     if (Depth > 0)
        //     {
        //         return data[Depth - 1];
        //     }
        //     else
        //     {
        //         Console.WriteLine("stack empty, returning 0");
        //         return 0;
        //     }
        // }
//Why does the data need to be represented as a string?
        // public override string ToString()
        // {
        //     StringBuilder b = new StringBuilder();
        //     b.Append('[');
        //     for (int i = Depth - 1; ; i--)
        //     {
        //         b.Append(data[i]);
        //         if (i == 0)
        //             return b.Append(']').ToString();
        //         b.Append(", ");
        //     }
        // }

        // public void Clear()
        // {
        //     Depth = 0;
        // }
    // }

