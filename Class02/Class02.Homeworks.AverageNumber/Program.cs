using System;

namespace Class02.Homeworks.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the Fourth number: ");
            int fourthNumber = int.Parse(Console.ReadLine());

            int average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

            Console.WriteLine("The average of " + firstNumber + ", " + 
                secondNumber + ", " + thirdNumber + ", " + 
                "and " + fourthNumber + " is: " + average);
        }
    }
}
