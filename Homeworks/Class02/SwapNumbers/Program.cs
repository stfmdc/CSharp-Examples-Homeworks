namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite Vaš prvi broj: ");
            string numOne = Console.ReadLine();
            int numOne1 = Convert.ToInt32(numOne);
            Console.Write("Unesite Vaš drugi broj: ");
            string numTwo = Console.ReadLine();
            int numTwo1 = Convert.ToInt32(numTwo);

            int temp = numOne1; // temp ---> temporary variable - savet sa neta :)
            numOne1 = numTwo1;
            numTwo1 = temp;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Vaši brojevi su uspešno zamenili mesta!");
            Console.WriteLine("Sada je Vaš prvi broj: " + numOne1);
            Console.WriteLine("Sada je Vaš drugi broj: " + numTwo1);
            Console.WriteLine("--------------------------------------------------");

        }
    }
}
