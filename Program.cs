using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;

            Console.WriteLine("Please, enter value: ");
            bool isValidInput = double.TryParse(Console.ReadLine(), out double value);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid number input.");
                return;
            }

            Console.WriteLine("Convert to (enter kw or hp):");
            string convertTo = Console.ReadLine().ToLower();

            if (convertTo == "kw")
            {
                result = HpToKw(value); // korisnik uneo HP -> konvertujemo u KW
            }
            else if (convertTo == "hp")
            {
                result = KwToHp(value); // korisnik uneo KW -> konvertujemo u HP
            }
            else
            {
                Console.WriteLine("Invalid conversion unit.");
                return;
            }

            Console.WriteLine("Converted result: " + result);
        }

        private static double KwToHp(double kw)
        {
            return kw / 0.745699872;
        }

        private static double HpToKw(double hp)
        {
            return hp * 0.745699872;
        }
    }
}
