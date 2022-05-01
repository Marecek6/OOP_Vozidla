using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Vozidla
{
    class Vozidlo
    {
        protected string znacka;
        protected double spotreba;
        protected int cesta;
        protected double cenaPh;

        public string Znacka
        {
            get
            {
                return znacka;
            }
            private set
            {
                string z = value;
                z = char.ToUpper(z[0]) + z.Substring(1);
                znacka = z;
            }
        }
        public double Spotreba
        {
            get
            {
                return spotreba;
            }
            private set
            {
                spotreba = value;
            }
        }

        public int Cesta
        {
            get
            {
                return cesta;
            }
            set
            {
                cesta = value;
            }
        }

        public double Cena
        {
            get
            {
                return cenaPh;
            }
            private set
            {
                cenaPh = value;
            }
        }

        public Vozidlo(string znacka, double spotreba, int cesta, double cenaPh)
        {
            Znacka = znacka;
            Spotreba = spotreba;
            Cesta = cesta;
            Cena = cenaPh;
        }

        public double Spotrebovano()
        {
            return (Spotreba / 100) * Cesta;
        }

        public double CenaCesty()
        {
            return (Cena / 100) * Cesta;
        }

        public override string ToString()
        {
            string s = "Vozidlo znacky " + Znacka + " behem cesty " + Cesta + " km spotrebovalo " + Spotrebovano() + " l a tato cesta stala " + CenaCesty() + " kč";
            return s;
        }
    }
}
