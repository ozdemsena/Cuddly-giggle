using System;

namespace FlexibleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flexible Calculator");
            Console.Write("Enter numbers and operations: ");
            string input = Console.ReadLine();

            double result = PerformCalculation(input);

            Console.WriteLine("Result: " + result);
        }

        static double PerformCalculation(string expression)
        {
            string[] expressions = expression.Split(' ');
            double result = Convert.ToDouble(expressions[0]);
            char op = '+';

            for (int i = 1; i < expressions.Length; i++)
            {
                if (IsOperator(expressions[i]))
                {
                    op = Convert.ToChar(expressions[i]);
                }
                else
                {
                    double num = Convert.ToDouble(expressions[i]);

                    switch (op)
                    {
                        case '+':
                            result += num;
                            break;
                        case '-':
                            result -= num;
                            break;
                        case '*':
                            result *= num;
                            break;
                        case '/':
                            if (num != 0)
                            {
                                result /= num;
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero!");
                                return 0;
                            }
                            break;
                        default:
                            Console.WriteLine("Error: Invalid operation!");
                            return 0;
                    }
                }
            }

            return result;
        }

        static bool IsOperator(string str)
        {
            return str == "+" || str == "-" || str == "*" || str == "/";
        }
    }
}

