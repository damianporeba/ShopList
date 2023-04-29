using System;
using System.Net.Sockets;

namespace Shoplist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in the Shop List console App!");
            Console.WriteLine("Let me know what you want to do...");
            Console.WriteLine("1. Add new product to list");
            Console.WriteLine("2. Remove product from list");
            Console.WriteLine("3. Show current shopping list");
            Console.WriteLine("4. Show products from particular categories");
            char opition = Console.ReadKey().KeyChar;

            switch (opition)
            {
                case '1':
                    Console.WriteLine("Podaj nazwę produktu:...");
                    
                    break;

            }
        }
    }
}