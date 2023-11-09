using System;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }

        public (string, string) GetNumbersForOperation()
        {
            Console.WriteLine("Enter 2 integers for the operation");
            var FirstOperand = Console.ReadLine();
            var SecondOperand = Console.ReadLine();

            return (FirstOperand, SecondOperand);
        }

    }
}
