namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            firstName = "Stefan";
            string lastName = "Mandic";

            int age = 30; // int je uvek broj int=integral

            // jednolinijski komentar, multilajn komentar /*komentar*/
            // izmedju {} je kod-blok

            Console.WriteLine("Hi, my name is " + firstName + " " + lastName + " and I am " + age + " years old.");
            Console.WriteLine($"Hi, my name is {firstName} {lastName} and I am {age} years old."); // interpolacija stringa, daleko laksi nacin, obavezan $
        }
    }
}
