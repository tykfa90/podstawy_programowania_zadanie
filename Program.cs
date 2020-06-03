using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace podstawy_programowania_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1: a)");

            Console.WriteLine(Program.Silnia(12));
            Console.ReadLine();
        }

        private static BigInteger Silnia(int liczba)
        {
            if (liczba == 0)
                return 1;
            else
                return liczba * Silnia(liczba - 1);
        }
    }
}
