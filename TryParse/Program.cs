using System;
namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat;
            if (!int.TryParse(Console.ReadLine(), out resultat))
            {
                Console.WriteLine("Skriv in en siffra.");
            }
            else
            {
                Console.WriteLine(resultat);
            }
        }
        static bool TryParse(string s, out int result)
        {
            if (int.Parse(s) != null)
            {
                result = int.Parse(s);
                return true;
            }
            else
            {
                result = 0;
                return false;
            }
        }
    }
}