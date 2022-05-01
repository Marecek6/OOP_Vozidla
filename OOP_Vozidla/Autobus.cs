using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vozidla
{
    class Autobus : Vozidlo
    {
        private int cenaListku;
        private int pocetPasazeru;
        public int CenaListku
        {
            get
            {
                return cenaListku;
            }
            set
            {
                cenaListku = value;
            }
        }

        public int PocetPasazeru
        {
            get
            {
                return pocetPasazeru;
            }
            set
            {
                pocetPasazeru = value;
            }
        }
        public Autobus(string znacka, double spotreba, int cesta, double cenaPh, int cenaListku, int pocetPasazeru) : base(znacka, spotreba, cesta, cenaPh)
        {
            PocetPasazeru = pocetPasazeru;
            CenaListku = cenaListku;
        }

        public double Vydelek()
        {
            return (PocetPasazeru* CenaListku) - ((cenaPh / 100)*cesta);
        }
    }
}
