using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar2PAW
{
    class Administratie:Zoo
    {

        private string numeCeo;
        private string locatieAdministratie;

        public string NumeCeo
        {
            get { return numeCeo; }
            set { if (value.Length > 5) numeCeo = value; }
        }

        public string LocatieAdministratie
        {
            get { return locatieAdministratie; }
            set { if (value.Length > 5) locatieAdministratie = value; }
        }

        public Administratie(string ceo, string locat,string de,string ad, List<Animal> ls) : base(de, ad, ls)
        {
            numeCeo = ceo;
            locatieAdministratie = locat;
        }

        public override string ToString()
        {

            return "Numele CEO ului este " + numeCeo + " iar administratia se afla in " +
                locatieAdministratie;
        }

    }
}
    