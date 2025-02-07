using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyakorlos
{
	internal class Karakter
	{
		private string name;
		private int szint;
		private int eletero;
		private int ero;

		public string Name { get => name; set => name = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }

		public Karakter(string name, int szint, int eletero, int ero)
		{
			this.name = name;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}

		public Karakter(string name, int ero)
		{
			this.name = name;
			szint = 1;
			eletero = 100;
			this.ero = ero;
		}

		public void Tamadas()
		{
            Console.WriteLine($"{name} támad {ero} erővel");
        }

		public void Gyogyulas(int mennyiseg)
		{
			eletero += mennyiseg;
		}

		public void Szintlepes()
		{
			szint++;
			ero++;
		}

		public override string ToString()
		{
			return $"{name} / {szint}. szint / {eletero} elet / {ero} ero";
		}








	}

}
