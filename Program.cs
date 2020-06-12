using System;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace podstawy_programowania_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica = new int[10,10];
            Program.TwoDimTableFill(tablica);

            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Utworzona tablica ma postać: ");
            Program.ArrayPrinter(tablica);
            Console.ReadLine();
        }

        private static void ArrayPrinter(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static int[,] TwoDimTableFill(int[,] tablica)
        {
            int licznik = 2;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tablica[i, j] = licznik;
                    licznik += 2;
                }
            }
            return tablica;
        }
    }
}
