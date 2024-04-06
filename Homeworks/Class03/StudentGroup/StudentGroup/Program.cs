using System.Collections;
using System.ComponentModel.Design;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Stefan", "Marko", "Janko", "Petar", "Goran" };

            int userInput;
            do
            {
                Console.Write("Molimo unestite broj grupe studenata čija imena želite da vidite na ekranu (trenutno dostupni brojevi 1 i 2): ");
            } while (!int.TryParse(Console.ReadLine(), out userInput) || (userInput != 1 && userInput != 2));

            if (userInput == 1)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Lista studenata iz Grupe 1 je:");
                Console.WriteLine("--------------------------------------");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine("--------------------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Lista studenata iz Grupe 2 je:");
                Console.WriteLine("--------------------------------------");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine("--------------------------------------");
            }

        }
    }
}
