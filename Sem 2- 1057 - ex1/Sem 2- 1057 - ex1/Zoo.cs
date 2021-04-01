using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_2__1057___ex1
{
    class Zoo:ICloneable
    {
        private string denumire;
        private string adresa;
        private List<Animal> lista = new List<Animal>();

        public string Denumire
        {
            get { return denumire; }
            set { if (value.Length> 5) denumire = value; }
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

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
        public Zoo Clone()
        {
            Zoo nou = (Zoo)((ICloneable)this).Clone();
            List<Animal> copie = new List<Animal>();
            foreach (Animal a in lista)
                copie.Add(a.Clone());

            nou.lista = copie;
            return nou;
        }

    }

}
