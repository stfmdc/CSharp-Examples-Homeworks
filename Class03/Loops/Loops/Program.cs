using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// - FOR - loop

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i: {i}");
            }
            Console.WriteLine("----------------------------------------------------------------");


            // --- BESKONACNA PETLJA ---

            for (; ; )
            {
                Console.WriteLine("This will go on forever unless you enter X!");
                string userInput = Console.ReadLine();

                if (userInput == "X" || userInput == "x")
                    break;
            }

            Console.WriteLine("We are outside of the loop...");
            Console.WriteLine("----------------------------------------------------------------");

            // FOR - REVERSE FOR LOOP

            for (int i = 10; i > 0; i--)
                Console.WriteLine($"The value of i: {i}");
                Console.WriteLine("Happy New Year!");
                Console.WriteLine("----------------------------------------------------------------");

            // WHILE LOOP

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"The value is: {counter}");
                counter++;
            }

            Console.WriteLine("We are outside of the WHILE LOOP...");
            Console.WriteLine("----------------------------------------------------------------");

            // INFINITE WHILE LOOP

            string userInputx = string.Empty;
            while (userInputx != "X" && userInputx != "x")
            {
                Console.WriteLine("This will go on forever unless you enter X");
                userInputx = Console.ReadLine();
            }

            Console.WriteLine("We are outside of the INFINITE WHILE LOOP...");
            Console.WriteLine("----------------------------------------------------------------");

            // DO-WHILE LOOP

            int doWhileCounter = 0;
            do
            {
                Console.WriteLine($"The value of counter is: {doWhileCounter}");
            } while (doWhileCounter++ < 10);


            int anotherCounter = 100;
            do
            {
                Console.WriteLine($"Another counter value is: {anotherCounter}");
            } while (anotherCounter++ < 10); // izvrsava se samo jednom zbog vrednosti 100

            Console.WriteLine("We are outside of the DO WHILE LOOP...");
            Console.WriteLine("----------------------------------------------------------------");*/

            // EXERCIZE 1

            // part one
            Console.WriteLine("Brojač od broja 1 do Vašeg broja.");
            Console.Write("Unesite neki broj: ");
            int exInput1 = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= exInput1; i++)
                {
                    Console.WriteLine(i);
                }

            // part two
            Console.WriteLine("Brojač od Vašeg broja do broja 1.");
            Console.Write("Unesite neki broj: ");
            int exInput2 = Convert.ToInt32(Console.ReadLine());

            for (int i = exInput2; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }

            // EXERCIZE 2

            // part one
            Console.WriteLine("Brojač parnih brojeva od broja 2 do Vašeg broja.");
            Console.Write("Unesite neki broj: ");
            int exInput3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= exInput3; i += 2)
                {
                    Console.WriteLine(i);
                }

            // part two
            Console.WriteLine("Brojač neparnih brojeva od broja 1 do Vašeg broja.");
            Console.Write("Unesite neki broj: ");
            int exInput4 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= exInput4; i += 2)
            {
                Console.WriteLine(i);
            }

            // EXERCIZE 3
            Console.WriteLine("Brojač brojeva od broja 1 do Vašeg broja koji nisu deljivi sa brojevima 3 i 7.");
            Console.Write("Unesite neki broj: ");
            int exInput5 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= exInput5; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }

                if (i == 100)
                {
                    Console.WriteLine("Dostignut je limit! Brojač broji do broja 100.");
                    break;
                }
            }
            /*  DRUGI NACIN ZA EXERCIZE 3
             
                Console.WriteLine("Enter number: ");
                int iputNum4 = int.Parse(Console.ReadLine());
            
                int j = 1;
 
                while (j < iputNum4)
                {
                  if (j % 3 == 0 || j % 7 == 0)
                  {
                      j++;
                      continue;
                  }

                  Console.WriteLine(j);
                  j++;
 
                  if (j == 100)
                  {
                      Console.WriteLine("The limit is reached and stop counting.");
                      break;
                  }
                }
             
            */

        }
    }
}
