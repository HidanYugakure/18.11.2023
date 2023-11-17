using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._11._2023.Models
{
    internal class GunTypes
    {
        public static string GunName = default;

        public void GunMethodTypes()
        {
            Console.WriteLine("1. Phantom"); //silah adlari ile aram olmadigina gore Valorant silahlarindan istifade etdim
            Console.WriteLine("2. Spectre");
            Console.WriteLine("3. Ghost");
            Console.WriteLine("4. Ares");

            ConsoleKeyInfo enterKey = Console.ReadKey();
            if (enterKey.Key == ConsoleKey.D1 || enterKey.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                Console.WriteLine("Phantom seçildi");
                Thread.Sleep(1000);
            }
            if (enterKey.Key == ConsoleKey.D2 || enterKey.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                Console.WriteLine("Spectre seçildi");
                Thread.Sleep(1000);
            }
            if (enterKey.Key == ConsoleKey.D3 || enterKey.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                Console.WriteLine("Ghost seçildi.");
                Thread.Sleep(1000);
            }
            if (enterKey.Key == ConsoleKey.D4 || enterKey.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                Console.WriteLine("Ares seçildi.");
                Thread.Sleep(1000);
            }
        }
    }
}
