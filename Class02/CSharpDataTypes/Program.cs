using System.Xml.Linq;

namespace CSharpDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Types

            int integerVariable1 = 5;
            // int integerVariable2; samo je deklarisana varijabla - bez vrednosti/inicijalizacije
            int integerVariable2 = 0;

            int integerVariable3 = 3100020;

            Console.WriteLine("Vrednost varijable 1 je: " + integerVariable1);
            Console.WriteLine("Vrednost varijable 2 je: " + integerVariable2);

            integerVariable1 = 500;
            integerVariable1 = 1000;

            Console.WriteLine("Vrednost varijable 1 je: " + integerVariable1);

            integerVariable1 = -500;

            // uint positiveNumberOnly = 300;

            float floatVariable = 2.5F; // mora F na kraju
            double doubleVariable = 2.5;

            Console.WriteLine($"Vrednost floatVariable je: {floatVariable}");
            Console.WriteLine("Vrednost doubleVariable je: " + doubleVariable);

            string message = "Hello world!";
            char singleCharacterValue = 'a'; // idu jednostruki navodnici

            Console.WriteLine(message);

            bool isPrinted = false;
            bool isEnabled = true;

            Console.WriteLine($"Document is printed: {isPrinted}");
            Console.WriteLine($"Document is enabled: {isEnabled}");

            // bad example
            string firstname = "Stefan 1";
            string FIRSTNAME = "Stefan 2"; // velika slova kod bitnih stvari npr CONFIGURATION_KEY_ID - iz baze npr...
            string FirstName = "Stefan 3";

            Console.WriteLine(firstname);
            Console.WriteLine(FIRSTNAME);
            Console.WriteLine(FirstName);

            // matematicke operacije
            int firstNumber = 10;
            int secondNumber = 20;

            int sum = firstNumber + secondNumber;
            int multipilcationResult = firstNumber * secondNumber;

            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Result of multipilcation is {multipilcationResult}");

            // unarni operator - radi sam sa sobom
            firstNumber++;
            firstNumber--;
            ++firstNumber;

            firstNumber += 10; //firstNumber = firstNumber + 10
            Console.WriteLine("--------------------------------------------------------------");

            // EXERCIZE 1

            int ex_one = 10;
            int ex_two = 3;
            int ex_three = ex_one / ex_two;

            Console.WriteLine($"Rezultat deljenja je {ex_three}");

            double doubleExOne = 10;
            double doubleExTwo = 3;
            double doubleExThree = doubleExOne / doubleExTwo;

            Console.WriteLine($"Rezultat deljenja je {doubleExThree}");
            Console.WriteLine("--------------------------------------------------------------");

            // EXERCIZE 2

            string fName = "Stefan";
            string lName = "Mandic";
            string flName = fName + " " + lName;

            Console.WriteLine(flName);

            string numOne = "9";
            string numTwo = "3";
            string numThree = numOne + " " + numTwo;

            Console.WriteLine(numThree);
            Console.WriteLine("--------------------------------------------------------------");

            // EXERCIZE 3

            int nbr = 10;
            string nbrTxt = "Ovo je broj deset";
            string nbrTxtSum = nbrTxt + " - " + nbr;

            Console.WriteLine(nbrTxtSum);
            Console.WriteLine("--------------------------------------------------------------");

            // EXERCIZE 4

            int credits = 102;
            int price = 5;
            int messages = credits / price;

            Console.WriteLine($"Mozemo da posaljemo {messages} poruka.");
            Console.WriteLine("--------------------------------------------------------------");

        }
    }
}
