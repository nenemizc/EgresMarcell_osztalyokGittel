﻿namespace OOPgyakorlos
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


        }
	}
}
