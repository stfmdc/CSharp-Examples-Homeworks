namespace OurFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;

            Console.WriteLine("Vase ime je?");
            firstName = Console.ReadLine();

            Console.WriteLine("Vase prezime je?");
            lastName = Console.ReadLine();

            Console.WriteLine("Vase godine su?");
            age = int.Parse(Console.ReadLine());

            // kod godina moze i ovako... izmedju linija 17 i 18... 
            // string ageInput = Console.ReadLine();
            // age = int.Parse(ageInput); <--- konvertuje string u int

            Console.WriteLine($"Uneti podaci su: {firstName} {lastName} {age}");
        }
    }
}
