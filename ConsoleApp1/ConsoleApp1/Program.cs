using ConsoleApp1.Models;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Weapon weapon = new Weapon();
            for (int i = 0; true; i++)
            {
				Console.WriteLine(" 0-Informasiya Almaq \n 1-Shoot \n 2-Fire \n 3-GetRemainBulletCount \n 4-Reload \n 5-ChangeFireMode \n 6-Proqramdan cixin... \n C-Silah yarat...");
				string secim = Console.ReadLine();

				switch (secim)
				{
					case "0":
						Console.WriteLine($"Silahin tutumu: {weapon.tutum} \nSilahdaki gulle sayi: {weapon.sayi} \nModu: {weapon.modu}");
						break;
					case "1":
						weapon.Shoot();
						break;
					case "2":
						weapon.Fire();
						break;
					case "3":
						weapon.GetNeededBulletCount();
						break;
					case "4":
						weapon.Reload();
						break;
					case "5":
						weapon.ChangeFireMode();
						break;
					case "c":
						weapon.CreateWeapon();
						break;
					case "6":
						return;
					default:
                        Console.WriteLine("Duz secim edin!!!");
                        break;
				}

			}

        }
	}
}