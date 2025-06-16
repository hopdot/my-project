// HCOINX Slots – Meme Coin Edition Game Logic in C# (console-based)
using System;
using System.Collections.Generic;

namespace HcoinxSlots
{
    class Program
    {
        static readonly string[] symbols = { "🍒", "🍋", "🍊", "🍇", "⭐", "🍉" };

        static void Main(string[] args)
        {
            Console.Title = "HCOINX Slots – Meme Coin Edition";
            Console.WriteLine("\n🎰 Welcome to HCOINX Slots – Meme Coin Edition 🎰\n");

            Console.Write("Enter Wallet Address: ");
            string wallet = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(wallet) || wallet.Length < 20)
            {
                Console.WriteLine("\nInvalid wallet address. Please try again.");
                return;
            }

            Console.WriteLine("\nChoose Meme Coin:");
            Console.WriteLine("1. Dogecoin (DOGE)");
            Console.WriteLine("2. Shiba Inu (SHIB)");
            Console.WriteLine("3. Pepe (PEPE)");
            Console.Write("Select coin (1-3): ");

            int coinChoice;
            string coin = "";

            if (int.TryParse(Console.ReadLine(), out coinChoice))
            {
                switch (coinChoice)
                {
                    case 1:
                        coin = "DOGE"; break;
                    case 2:
                        coin = "SHIB"; break;
                    case 3:
                        coin = "PEPE"; break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Random rng = new Random();

            Console.WriteLine("\nSpinning reels...\n");
            string r1 = symbols[rng.Next(symbols.Length)];
            string r2 = symbols[rng.Next(symbols.Length)];
            string r3 = symbols[rng.Next(symbols.Length)];

            Console.WriteLine($"[ {r1} | {r2} | {r3} ]\n");

            if (r1 == r2 && r2 == r3)
            {
                Console.WriteLine($"🎉 JACKPOT! Paid out in {coin}.\nTx sent to: {wallet}");
                // Add actual memecoin transfer logic here
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}
