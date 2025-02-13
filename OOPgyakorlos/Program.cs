namespace OOPgyakorlos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Konyv konyv1 = new("A kis herceg", "Antonie de Saint-Rxupéry", 1943, 96, 2500);
			Konyv konyv2 = new("Ez még keszül", "Én");

			Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(1000);

			Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyOldalMaradt(20));


			Film film1 = new("Drive", "Nicolas Winding Refn", 100, "Thriller", true);
			Film film2 = new("Skibidi Toilet the movie", "Michael Bay");

			film1.Jatszas();
			film2.MufajModositas("Dráma");
			film1.HosszNovelese(12);

            Console.WriteLine("\n" + film1.ToString() + "\n" + film2.ToString());

			Karakter karakter1 = new("Bökő Emílió", 5, 214, 8);
			Karakter karakter2 = new("Kelenföldi Ronáldo", 3);

			karakter2.Tamadas();
			karakter1.Gyogyulas(25);
			karakter1.Szintlepes();

            Console.WriteLine("\n" + karakter1.ToString() + "\n" + karakter2.ToString());

			Urhajo urhajo1 = new("István", 2, 15, 85);
            Urhajo urhajo2 = new("Szilárd", 15);

			urhajo2.Indulas();
			urhajo1.Tankolas(10);
			urhajo1.Landolas();

            Console.WriteLine("\n" + urhajo1.ToString() + "\n" + urhajo2.ToString());
        }
	}
}
