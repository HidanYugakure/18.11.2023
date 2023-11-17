using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._11._2023.Models
{
    internal class TemsSelect
    {
        public void SelectYourGunsTems()
        {
            Console.Clear();
            Console.WriteLine("1. Agent");
            Console.WriteLine("2. Legacy");
            Console.WriteLine("3. Sakura");
            Console.WriteLine("4. Sovereign");
          
            ConsoleKeyInfo enterKey = Console.ReadKey();
            if (enterKey.Key == ConsoleKey.W)
            {
                Console.Clear();
                Console.WriteLine(" Agent themes seçildi");
                Thread.Sleep(1000);
            }
            if (enterKey.Key == ConsoleKey.M)
            {
                Console.Clear();
                Console.WriteLine(" Legacy seçildi");
                Thread.Sleep(1000);
            }
            if (enterKey.Key == ConsoleKey.N)
            {
                Console.Clear();
                Console.WriteLine(" Sakura seçildi");
                Thread.Sleep(1000);
            }
            if (enterKey.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Console.WriteLine(" Sovereign seçildi");
                Thread.Sleep(1000);
            }
        }

    }
}
