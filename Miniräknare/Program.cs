using System.Numerics;

namespace Miniräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tal1 = 0;
            int tal2 = 0;
            int summa = 0;

            Console.WriteLine("Tryck (1) för Addition");
            Console.WriteLine("Tryck (2) för Subtraktion");
            Console.WriteLine("Tryck (3) för Multiplikation");
            Console.WriteLine("Tryck (4) för Division");
            Console.WriteLine("Tryck (5) för att avsluta programmet");
            int val = int.Parse(Console.ReadLine());

            if (val != 5) 
            {
                Console.Write("Skriv in första talet: ");
                tal1 = int.Parse(Console.ReadLine());

                Console.Write("Skriv in andra talet: ");
                tal2 = int.Parse(Console.ReadLine());
            }




            switch (val)

            {
                case 1:
                    Adition(tal1, tal2);

                    break;

                case 2:

                    Subtraktion(tal1, tal2);
                    
                    break;
                
                case 3:

                    Multiplication(tal1, tal2);

                    break;
                
                
                case 4:

                    Division(tal1, tal2);

                    break;


                case 5:
                   Console.WriteLine("Programmet avslutas");
                    break;

                   

            }





            }

        private static void Division(int tal1, int tal2)
        {
            int summa = tal1 / tal2;
            Console.WriteLine($"{tal1} / {tal2} = {summa}");

        }

        private static void Multiplication(int tal1, int tal2)
        {
            int summa = tal1 * tal2;
            Console.WriteLine($" {tal1} * {tal2} = {summa}");
        }

        private static void Subtraktion(int tal1, int tal2)
        {
            int summa = tal1 - tal2;
            Console.WriteLine($"{tal1} - {tal2} = {summa}");
        }

        private static void Adition(int tal1, int tal2)
        {


           int summa = tal1 + tal2;
            Console.WriteLine($"{tal1} + {tal2} = {summa}");

         
        }
    }
    }



