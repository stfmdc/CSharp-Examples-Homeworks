namespace Branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type any positive or negative number: ");
            int userInputNumber = Convert.ToInt32(Console.ReadLine());

            if (userInputNumber > 0)
                Console.WriteLine("The number is positive!");
            else if (userInputNumber < 0)
                Console.WriteLine("The number is negative!");
            else
                Console.WriteLine("The number is zero!");

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1. Monday\n2. Tuesday\n3. Wednesday\n4. Thursday\n5. Friday\n6. Saturday\n7. Sunday");
            int userInputDay = Convert.ToInt32(Console.ReadLine());

            switch (userInputDay)
            {
                case 1:
                    Console.WriteLine("Work day :(");  // PROPADANJE - skracivanje koda...ostavimo case 1-4 prazne a cita iz case 5
                    break;
                case 2:
                    Console.WriteLine("Work day :(");
                    break;
                case 3:
                    Console.WriteLine("Work day :(");
                    break;
                case 4:
                    Console.WriteLine("Work day :(");
                    break;
                case 5:
                    Console.WriteLine("Work day :(");
                    break;
                case 6:
                    Console.WriteLine("Happy day :)");
                    break;
                case 7:
                    Console.WriteLine("Happy day :)");
                    break;

                default:
                    Console.WriteLine("Outside of valid values!");
                    break;
            }
        }
    }
}
