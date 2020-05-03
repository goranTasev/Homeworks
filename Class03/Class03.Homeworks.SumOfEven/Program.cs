using System;

namespace Class03.Homeworks.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[6];
       
            Console.Write("Enter integer no.1: ");
            numbersArray[0] = int.Parse(Console.ReadLine());

            Console.Write("Enter integer no.2: ");
            numbersArray[1] = int.Parse(Console.ReadLine());

            Console.Write("Enter integer no.3: ");
            numbersArray[2] = int.Parse(Console.ReadLine());

            Console.Write("Enter integer no.4: ");
            numbersArray[3] = int.Parse(Console.ReadLine());

            Console.Write("Enter integer no.5: ");
            numbersArray[4] = int.Parse(Console.ReadLine());

            Console.Write("Enter integer no.6: ");
            numbersArray[5] = int.Parse(Console.ReadLine());
           

            int sumOfEven = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] % 2 == 0)
                {
                    sumOfEven += numbersArray[i];
                }
            }

            Console.WriteLine("The result is: " + sumOfEven);


        }
    }
}
