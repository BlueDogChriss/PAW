using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar2PAW
{
    class Zoo:ICloneable
    {
        private string denumire;
        private string adresa;
        private List<Animal> lista = new List<Animal>();

        public string Denumire
        {
            get { return denumire; }
            set { if (value.Length > 2) denumire = value; }
        }
        public string Adresa
        {
            get { return adresa; }
            set { if (value.Length > 5) adresa = value; }
        }

        public List<Animal> Lista 
        { 
            get { return lista; } 
            set { lista = value; }
        }
        public Zoo() { }

        public Zoo(string de,string ad,List<Animal> ls) 
        {
            denumire = de;
            adresa = ad;
            if (ls.Count > 0) { lista = ls; }

        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public Zoo Clone()
        {
            Zoo nou= (Zoo)this.MemberwiseClone();
            List<Animal> copie = new List<Animal>();
            nou.Lista = copie;
            foreach (Animal a in this.lista)
                nou.lista.Add(a.Clone());
            nou.lista = copie;
            return nou;
        }
        public override string ToString()
        {
            String zoo="";
            zoo += "denumirea este " + denumire + " adresa este " + adresa + ".\nAnimalele vor fi: \n";
            foreach(Animal a in Lista)
            {
                zoo += a.ToString() + "\n";
            }
            return zoo;
        }
    }
}
