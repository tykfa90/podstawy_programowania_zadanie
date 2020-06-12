using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace podstawy_programowania_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANKOMAT \n");
            Console.WriteLine("Wybierz operację:\n" +
                "1. Wypłata gotówki.\n" +
                "2. Sprawdzenie stanu konta.\n" +
                "3. Wyjście.");
            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    Program.Wyplata();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    break;
            }
        }

        private static void Wyplata()
        {
            Console.WriteLine("Proszę podać kwotę do wypłaty: ");
            bool running = true;
            while (running)
            {
                string userAmount = Console.ReadLine();
                bool check = int.TryParse(userAmount, out int amount);
                if (check == true || amount != 0 || amount % 10 == 0)
                {
                    
                    running = false;
                }
                else
                {
                    Console.WriteLine("Proszę wprowadzić wielokrotność kwoty 10 zł. Proszę ponownie wybrać kwotę do wypłaty: ");
                }
            }
        }
    }
}
