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
		}
	}
}
