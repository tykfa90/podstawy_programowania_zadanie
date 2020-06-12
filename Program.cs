using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace podstawy_programowania_zadanie
{
    class Program
    {
        private static double total;
        private static string order;

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Automat Z Napojami\n\n" +
                "Dostępne produkty:\n" +
                "1. Kawa      - 1,50 zł\n" +
                "2. Hebrata   - 1,00 zł\n" +
                "3. Czekolada - 2,00 zł");
                bool check = int.TryParse(Console.ReadLine(), out int userInput);
                if (check)
                {
                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine("Wybrano napój: Kawa Koszt: 1,50 zł.");
                            order += "Kawa +1,50 zł ";
                            total += 1.50;
                            break;
                        case 2:
                            Console.WriteLine("Wybrano napój: Herbata Koszt: 1,00 zł.");
                            order += "Herbata +1,00 zł ";
                            total += 1.00;
                            break;
                        case 3:
                            Console.WriteLine("Wybrano napój: Czekolada Koszt: 2,00 zł.");
                            order += "Czekolada +2,00 zł ";
                            total += 2.00;
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(order);
                    Console.WriteLine("Doliczyć dodakowy cukier? Cena: 0,50 zł.\n" +
                        "1. TAK\n" +
                        "2. NIE");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        order += " + dodatkowy cukier";
                        total += 0.50;
                        Console.WriteLine(order);
                    }
                    Console.WriteLine("Potwierdź zamówienie:\n" +
                        "1. OK\n" +
                        "2. Wróć.");
                    int confirm = int.Parse(Console.ReadLine());
                    if (confirm == 1)
                    {
                        Console.WriteLine("Twoje zamówienie: " + order + "\n" +
                            "OPŁACONO! Proszę odebrać napój. UWAGA, GORĄCE!");
                        Console.ReadLine();
                    }
                    else
                    {
                        continue;
                    }
                    running = false;
                }
                else
                {
                    Console.WriteLine("Proszę wybrać jeszcze raz.");
                }
            }
        }
    }
}
