using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyakorlos
{
	internal class Kem
	{
		private string kodnev;
		private string orszag;
		private int veszelySzint;
		private int sikerEsely;

        
        public string Kodnev { get => kodnev; set => kodnev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
        public int SikerEsely { get => sikerEsely; set => sikerEsely = value; }

        public Kem(string kodnev, string orszag, int veszelySzint, int sikerEsely)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            this.veszelySzint = veszelySzint;
            this.sikerEsely = sikerEsely;
        }

        public Kem(string kodnev, string orszag)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            veszelySzint = 5;
            sikerEsely = 50;
        }

        public void KuldetesInditasa()
        {
            Console.WriteLine("A küldeteés elkezdődött");
        }

        public void VeszelySzintNovelese(int mennyiseg)
        {
            veszelySzint += mennyiseg;
        }

        public void SikerEsejNovelese(int szazalek) //Az 'esej' a feladatban volt elírva
        {
            sikerEsely += szazalek;
        }

        public override string? ToString()
        {
            return $"{kodnev} / {orszag} / {veszelySzint} / {sikerEsely}";
        }
    }
}
