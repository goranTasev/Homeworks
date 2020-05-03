using System;

namespace Class02.Homework.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the operation: ");
            string operation = Console.ReadLine();
            int result = 0;
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                result = firstNumber / secondNumber;
            } else
            {
                Console.WriteLine("Wrong operation");
            }

            Console.WriteLine("The result is: " + result);
            


            Console.ReadLine();
        }
    }
}
