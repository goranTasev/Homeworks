using System;

namespace Class01.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trafic lights..");
            Console.WriteLine();

            System.Threading.Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Red light - STOP!");
            Console.ResetColor();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine();
            

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Yellow light - PREPARE!");
            Console.ResetColor();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Green light - GO!");
            Console.ResetColor();
            System.Threading.Thread.Sleep(3000);




            Console.ReadLine();
        }
    }
}
