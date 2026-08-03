using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichDemo
{
    internal class Calculator
    {
        public void Calculate()
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator (+, -, *, /)");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case "/":
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1 / num2}");
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
