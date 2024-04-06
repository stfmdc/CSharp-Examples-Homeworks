using System.Security.Cryptography;

namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prvi broj: ");
            string numOne = Console.ReadLine();
            int numOne1 = int.Parse(numOne);

            Console.Write("Unesite drugi broj: ");
            string numTwo = Console.ReadLine();
            int numTwo1 = int.Parse(numTwo);

            Console.Write("Odaberite računsku operaciju (+, -, /, *): ");
            string mathOper = Console.ReadLine();
            char mathOper1 = char.Parse(mathOper);

            int sum = numOne1 + numTwo1;
            int difference = numOne1 - numTwo1;
            int product = numOne1 * numTwo1;
            int quotient = numOne1 / numTwo1;

            switch (mathOper1)
            {
                case '+':
                    Console.WriteLine($"Zbir dva uneta broja je {sum}.");
                    break;
                case '-':
                    Console.WriteLine($"Razlika dva uneta broja je {difference}.");
                    break;
                case '*':
                    Console.WriteLine($"Proizvod dva uneta broja je {product}.");
                    break;
                case '/':
                    Console.WriteLine($"Količnik dva uneta broja je {quotient}.");
                    break;

                default:
                    Console.WriteLine("Niste uneli validne podatke.");
                    break;
            }
        }
    }
}
