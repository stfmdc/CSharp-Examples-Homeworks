namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your name: ");  // write - unos u istom redu; writeline - novi red za unos
            string userName = Console.ReadLine();

            Console.WriteLine($"Your name is: {userName}");

            Console.Write("How old are you: ");
            string userInputString = Console.ReadLine();
            int userAge = int.Parse(userInputString);

            Console.WriteLine($"You are {userAge} years old.");

            // a moze i ovako...

            int userAge2 = Convert.ToInt16(userAge);
            Console.WriteLine($"You are {userAge2} years old.");

            // nastavak...

            Console.WriteLine("What is the value of pi?");
            double piValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Your answer is {piValue}");
        }
    }
}
