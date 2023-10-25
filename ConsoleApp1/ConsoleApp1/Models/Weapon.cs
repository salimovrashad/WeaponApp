namespace ConsoleApp1.Models
{
	internal class Weapon
	{
		public int tutum = 40;
		public int sayi = 40;
		public float bossaniye = 80;
		public string modu = "avtomatik";

		public void Shoot()
		{
            if (sayi == 0)
            {
				Console.WriteLine("Gulle yoxdu...");
            }
            else
            {
				sayi = sayi - 1;
				Console.WriteLine($"Atis edildi. {sayi} qeder gulle qaldi...");
            }
        }
		public void Fire()
		{
            if (sayi == 0)
            {
                Console.WriteLine("Gulle yoxdu!!!");
            }
            else
            {
				Console.WriteLine($"Bosaltma saniyesi {(bossaniye/tutum)*sayi} saniyedir. ");
				sayi = 0;
				Console.WriteLine($"{sayi} gulle qaldi...");

			}
		}
		public void GetNeededBulletCount()
		{
			int number = tutum - sayi;
            Console.WriteLine($"{number} gulle lazimdi...");
        }
		public void Reload()
		{
			sayi = tutum;
            Console.WriteLine("Daraq yeniden doldu...");
        }
		public void ChangeFireMode()
		{
            if (modu == "tekli")
            {
				modu = "avtomatik";
            }
            else
            {
				modu = "tekli";
            }
            Console.WriteLine($"Modu {modu} olaraq deyisildi...");
        }
		public void CreateWeapon()
		{
            Console.WriteLine("Gulle tutumunu daxil edin: ");
			tutum = Convert.ToInt32(Console.ReadLine());
            if (tutum < 0)
            {
				Console.WriteLine("Duz reqem daxil edin!!!");
				return;
			}

			Console.WriteLine("Gulle sayini daxil edin: ");
			sayi = Convert.ToInt32(Console.ReadLine());
			if (sayi < 0)
			{
				Console.WriteLine("Duz reqem daxil edin!!!");
				return;
			}

			Console.WriteLine("Gulle bosalma saniyesini daxil edin: ");
			bossaniye = Convert.ToInt32(Console.ReadLine());
			if (bossaniye < 0)
			{
				Console.WriteLine("Duz reqem daxil edin!!!");
				return;
			}

			Console.WriteLine("Atis modunu daxil edin: ");
			modu = Console.ReadLine();
			if (!(modu == "tekli" || modu == "avtomatik"))
			{
				Console.WriteLine("Duz deyil!!!");
				return;
			}
		}
	}
}
