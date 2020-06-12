using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace podstawy_programowania_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1: b)");
            Console.WriteLine("Podaj podstawę silni: ");
            int liczba = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik dla silni o podstawie: " + liczba + " to: " + Program.Silnia(liczba));
            Console.ReadLine();
        }

        private static BigInteger Silnia(int liczba)
        {
            int wynik = 1;
            for (int i = 1; i <= liczba; i++)
            {
                wynik *= i;
            }
            return wynik;
        }
    }
}
