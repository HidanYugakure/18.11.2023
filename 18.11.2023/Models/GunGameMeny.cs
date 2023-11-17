namespace _18._11._2023.Models
{
    internal class GunGameMeny
    {
        public void GameMeny()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Başla");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("2. Silahınızı seçin");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("3. Silahınızın temasını seçin ");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("4. Çıxış");

            Console.WriteLine(GunTypes.GunName);
            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleKeyInfo enterkey = Console.ReadKey();
            if (enterkey.Key == ConsoleKey.D1 || enterkey.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                Console.WriteLine("Başla düyməsinə toxundunsa geri dönüş yoxdur....");
                Thread.Sleep(6000);
            }
            else if (enterkey.Key == ConsoleKey.D2 || enterkey.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                Console.WriteLine(" 5 növ silah mövcüddur özünüzə uyğun olanı seçin;");
                Thread.Sleep(6000);
                GunTypes gunTypes1 = new GunTypes();
                gunTypes1.GunMethodTypes();
            } 
            else if (enterkey.Key == ConsoleKey.D3 || enterkey.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                Console.WriteLine("4 növ Tema mövcüddur");
                Thread.Sleep(6000);
                TemsSelect temsTypes = new TemsSelect();
                temsTypes.SelectYourGunsTems();
            }
            else if(enterkey.Key == ConsoleKey.D4 || enterkey.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                Console.WriteLine("oyundan çixmaq vaxtıdır");
                Thread.Sleep(6000);
                System.Environment.Exit(0); //oyun çıxır.
            }
        }
    }
}
