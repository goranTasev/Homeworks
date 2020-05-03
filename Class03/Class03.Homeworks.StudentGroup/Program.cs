using System;

namespace Class03.Homeworks.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "Goran", "Oli", "Darko", "Marko", "Sarko" };
            string[] studentsG2 = new string[] { "Bojan", "Stojan", "Aleksandar", "Viktor", "Marija" };

            Console.WriteLine("Enter student group: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 1 )
            {
                Console.WriteLine("The Students in G1 are: ");
                for(int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            } 
            else if (input == 2)
            {
                Console.WriteLine("The Students in G2 are: ");
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            } else
            {
                Console.WriteLine("Wrong number!");
            }

            Console.ReadLine();
        }
    }
}
