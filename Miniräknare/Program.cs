using System.Numerics;

namespace Miniräknare
{
    internal class Program
    {
        static void Main(string[] args) {
            int tal1 = 0;
            int tal2 = 0;


            Console.WriteLine("Tryck (1) för Addition"); // meny för användaren
            Console.WriteLine("Tryck (2) för Subtraktion");
            Console.WriteLine("Tryck (3) för Multiplikation");
            Console.WriteLine("Tryck (4) för Division");
            Console.WriteLine("Tryck (5) för att avsluta programmet");


            int val;
            Console.Write("Ditt val: "); // fråga användaren efter val
            while (!int.TryParse(Console.ReadLine(), out val) || val < 1 || val > 5)// omvandlar sträng till heltal och
                                                                                    // kollar att det är mellan 1-5, annars fråga igen
            {
                Console.Write("Felaktigt val. Ange en siffra mellan 1 och 5: ");
            }


            if (val != 5) // om användaren inte väljer att avsluta, fråga efter tal
            {
                Console.Write("Skriv in första talet: "); // fråga efter första talet
                tal1 = int.Parse(Console.ReadLine());

                Console.Write("Skriv in andra talet: "); // fråga efter andra talet
                tal2 = int.Parse(Console.ReadLine());
            }




            switch (val) // switch för att välja vilken operation som ska utföras

            {
                case 1: // om användaren valde 1, utför addition
                    Addition(tal1, tal2);

                    break; 

                case 2: // om användaren valde 2, utför subtraktion

                    Subtraktion(tal1, tal2);
                    
                    break;
                
                case 3: // om användaren valde 3, utför multiplikation

                    Multiplication(tal1, tal2);

                    break;
                
                
                case 4: // om användaren valde 4, utför division

                    Division(tal1, tal2);

                    break;


                case 5: // om användaren valde 5, avsluta programmet
                    Console.WriteLine("Programmet avslutas");
                    break;

                   

            }





            }

        private static void Division(int tal1, int tal2) // metod för division
        {
            int summa = tal1 / tal2;
            Console.WriteLine($"{tal1} / {tal2} = {summa}");

        }

        private static void Multiplication(int tal1, int tal2) // metod för multiplikation
        {
            int summa = tal1 * tal2;
            Console.WriteLine($" {tal1} * {tal2} = {summa}");
        }

        private static void Subtraktion(int tal1, int tal2) // metod för subtraktion
        {
            int summa = tal1 - tal2;
            Console.WriteLine($"{tal1} - {tal2} = {summa}");
        }

        private static void Addition(int tal1, int tal2) // metod för addition

        {


           int summa = tal1 + tal2;
            Console.WriteLine($"{tal1} + {tal2} = {summa}");
              
         
        }
    }
    }



