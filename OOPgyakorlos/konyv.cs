using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyakorlos
{
	internal class Konyv
	{
		private string cim;
		private string szerzo;
		private int kiadasEve;
		private int oldalSzam;
		private int ar;

		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
		public int OldalSzam { get => oldalSzam; set => oldalSzam = value; }
		public int Ar { get => ar; set => ar = value; }

		public Konyv(string cim, string szerzo, int kiadasEve, int oldalSzam, int ar)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadasEve = kiadasEve;
			this.oldalSzam = oldalSzam;
			this.ar = ar;
		}

		public Konyv(string cim, string szerzo)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			kiadasEve = DateTime.Now.Year;
			oldalSzam = 200;
			ar = 3000;

		}

		public void Arnoveles(int osszeg)
		{
			ar += osszeg;
		}

		public void Kedvezmeny(double szazalek)
		{
			ar -= Convert.ToInt16(ar * (szazalek/100));
		}

		public int HanyOldalMaradt(int elolvasott)
		{
			return oldalSzam - elolvasott;
		}

		public override string? ToString()
		{
			return $"{cim} - {szerzo} / {oldalSzam} / {kiadasEve} - {ar}";
		}
	}
}
