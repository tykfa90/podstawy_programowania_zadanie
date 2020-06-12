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
            int accountBalance = 21975;
            Console.WriteLine("Stan konta wynosi: " + accountBalance + " Proszę podać kwotę do wypłaty: ");
            bool running = true;
            while (running)
            {
                string userAmount = Console.ReadLine();
                bool check = int.TryParse(userAmount, out int amount);
                if (check == true && amount != 0 && amount % 10 == 0 && amount <= accountBalance)
                {
                    int[] bills = {500,200,100,50,20,10};
                    foreach (int bill in bills)
                    {
                        int count = amount / bill;
                        amount -= (count*bill);
                        if (count > 0)
                        {
                        Console.WriteLine("Wypłacono " + count + " banknotów o nominale " + bill);
                        }
                    }
                    running = false;
                }
                else
                {
                    Console.WriteLine("\nProszę wprowadzić wielokrotność kwoty 10 zł. Proszę ponownie wybrać kwotę do wypłaty: ");
                    continue;
                }
                Console.ReadLine();
            }
        }
    }
}
