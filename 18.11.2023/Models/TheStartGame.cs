

namespace _18._11._2023.Models
{
    internal class TheStartGame
    {
        public int MərmiSayi = 25;
        public void BirAtış()
        {
            int Qavrayici = 25;
            MərmiSayi--;
            Console.WriteLine($"Silah atışı zamanı mərmi azalır 1 ədəd {MərmiSayi}/{Qavrayici}");

            if (MərmiSayi == 0)
            {
                Console.WriteLine("Mərmidə güllə azalır, yenilə...!!");
                YenidenDoldur();
            }
        }
        public void YenidenDoldur()
        {
            if (MərmiSayi == 25)
            {
                Console.WriteLine("Yenidən doldurmağa ehtiyac yoxdu");
                return; //IF de dayanmasi ucun istifade edilir
            }
            MərmiSayi = 25;
        }
        public void IkiAtış ()
        {
            int Qavrayici = 25;
            MərmiSayi = MərmiSayi - 2;
            Console.WriteLine($"silah atışında 1 mərmi azalir ve {MərmiSayi}/{Qavrayici}");

            if (MərmiSayi <= 0)
            {
                Console.WriteLine("Mərmi azalmağa başladı yeniləməyi unutma..!");
                YenidenDoldur();
            }
        }
        public void KlavisDinleyici()
        {

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.T:
                        BirAtış();
                        break;
                    case ConsoleKey.K:
                        IkiAtış();
                        break;
                    case ConsoleKey.R:
                        YenidenDoldur();
                        break;
                }
            }
        }
        public void CagirmaqStartTheGame()
        {
            KlavisDinleyici();
        }

    }
}


