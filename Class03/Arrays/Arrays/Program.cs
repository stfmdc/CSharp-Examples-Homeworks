namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fixed size array
            int[] numbersArray = new int[5];

            numbersArray[0] = 1;
            numbersArray[1] = 2;
            numbersArray[2] = 3;
            numbersArray[3] = 4;
            numbersArray[4] = 5;

            /* los nacin, previse koda
            Console.WriteLine("The array elements are:");
            Console.WriteLine(numbersArray[0]);
            Console.WriteLine(numbersArray[1]);
            Console.WriteLine(numbersArray[2]);
            Console.WriteLine(numbersArray[3]);
            Console.WriteLine(numbersArray[4]);
            */

            // dobar nacin, manje koda, lepse, preglednije...
            Console.WriteLine("The array elements are:");
            for (int i = 0; i < numbersArray.Length; i++)
                Console.WriteLine(numbersArray[i]);
                Console.WriteLine("-----------------------------------------------------");
            // NON FIXED ARRAY
            string[] studentsArray = new string[]
            {
                "Milica", "Tamara", "Goran", "Stefan", "Sava"
            };

            int[] studentsRatingsArray = new int[] { 10, 10, 10, 10, 10 };

            // for loop idealna za ispisivanje nizova
            Console.WriteLine("Students: ");
            
            //ForEach loop
            foreach (string student in studentsArray)
                Console.WriteLine(student);

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Students ratings:");
            foreach (int rating in studentsRatingsArray)
                Console.WriteLine(rating);

            Console.WriteLine("-----------------------------------------------------");

            // Exercize 1

            string[] wordsArray = { "Fudbal", "Tenis", "Odbojka", "Košarka", "Vaterpolo" };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5};
            char[] charArray = { 'a', 'b', 'c', 'd', 'e'};
            bool[] boolArray = { true, false, true, false, true };

            Console.WriteLine("Words:");
            foreach (string word in wordsArray)
                Console.WriteLine(word);
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Decimal:");
            foreach (double word in doubleArray)
                Console.WriteLine(word);
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Characters:");
            foreach (char word in charArray)
                Console.WriteLine(word);
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Values:");
            foreach (bool word in boolArray)
                Console.WriteLine(word);
            Console.WriteLine("-----------------------------------------------------");

            // EXERCIZE 2

            int[] intArray = new int[5];
            Console.WriteLine("Unesite 5 brojeva:");

            for (int i = 0; i < intArray.Length; i++)
            {
                string userInput = Console.ReadLine();
                intArray[i] = int.Parse(userInput);
            }

            int sum = 0;
            foreach (int num in intArray)
            {
                sum += num;
            }

            Console.WriteLine($"Zbir unetih brojeva je: {sum}");
            Console.WriteLine("-----------------------------------------------------");

            // EXERCIZE 3

            string[] stringArray = new string[10];

            int counter = 0;

            while (true)
            {
                Console.WriteLine("Unesite neko ime:");
                string name = Console.ReadLine();

                stringArray[counter] = name;
                counter++;

                Console.WriteLine("Da li želite da unesete novo ime?");

                if (Console.ReadLine() == "n")
                    break;
            }

            Console.WriteLine("Sačuvana imena su:");

            foreach (string currentName in stringArray)
                Console.WriteLine(currentName);
            Console.WriteLine("-----------------------------------------------------");

        }
    }
}
