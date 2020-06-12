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
            BigInteger[] tablica = new BigInteger[100];
            Program.FibonacciFill(tablica);

            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Utworzoną tablicę wypełniono liczbami: ");
            tablica.ToList().ForEach(i => Console.Write(i.ToString() + " ; "));
            Console.ReadLine();
        }

        private static BigInteger[] FibonacciFill(BigInteger[] tablica)
        {
            for (long i = 0; i <= 99; i++)
            {
                if (i == 0)
                {
                    tablica[i] = 0;
                }
                else if (i == 1)
                {
                    tablica[i] = 1;
                }
                else
                {
                    tablica[i] = tablica[i - 2] + tablica[i - 1];
                }
            }            
            return tablica;
        }
    }
}
