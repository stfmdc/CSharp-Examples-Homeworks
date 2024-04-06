namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[4];
            Console.WriteLine("Unesite neka 4 broja:");

            for (int i = 0; i < intArray.Length; i++)
            {
                string userInput = Console.ReadLine();
                intArray[i] = int.Parse(userInput);
            }

            int sum = 0;
            foreach (int num in intArray)
            {
                sum = sum + num;
            }

            int average = sum / intArray.Length;

            Console.WriteLine($"Prosek unetih brojeva je: {average}");
        }
    }
}
