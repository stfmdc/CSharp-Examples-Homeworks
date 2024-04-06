namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[6];
            Console.WriteLine("Unesite 6 brojeva:");

            for (int i = 0; i < intArray.Length; i++)
            {
                string userInput = Console.ReadLine();
                intArray[i] = int.Parse(userInput);
            }

            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    sum += intArray[i];
                }
            }

            Console.WriteLine($"Zbir parnih brojeva koje ste uneli je: {sum}");
        }
    }
}
