using System;

namespace Class02.Homeworks.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            
            (firstNumber, secondNumber) = (secondNumber, firstNumber);

            Console.WriteLine("After Swapping: ");
            Console.WriteLine("First Number: " + firstNumber);
            Console.WriteLine("Second Number: " + secondNumber);

            Console.ReadLine();
        }
    }
}
