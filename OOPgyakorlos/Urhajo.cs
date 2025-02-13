using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyakorlos
{
	internal class Urhajo
	{
		private string nev;
		private int sebesseg;
		private int utaskapacitas;
		private int uzemanyagSzint;

        public string Nev { get => nev; set => nev = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
        public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = value; }

        public Urhajo(string nev, int sebesseg, int utaskapacitas, int uzemanyagSzint)
        {
            this.nev = nev;
            this.sebesseg = sebesseg;
            this.utaskapacitas = utaskapacitas;
            this.uzemanyagSzint = uzemanyagSzint;
        }

        public Urhajo(string nev, int utaskapacitas)
        {
            this.nev = nev;
            sebesseg = 0;
            this.utaskapacitas = utaskapacitas;
            uzemanyagSzint = 100;
        }

        public void Indulas() 
        {
            sebesseg++;
            uzemanyagSzint--;
        }

        public void Tankolas(int mennyiseg)
        {
            uzemanyagSzint += mennyiseg;
        }

        public void Landolas()
        {
            sebesseg = 0;
        }

        public override string? ToString()
        {
            return $"{nev} / {sebesseg} / {utaskapacitas} / {uzemanyagSzint}";
        }
    }
}
