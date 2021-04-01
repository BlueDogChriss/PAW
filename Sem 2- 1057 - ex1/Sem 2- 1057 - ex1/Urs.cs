using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_2__1057___ex1
{
    class Urs:Animal
    {
        private bool hiberneaza;

        public bool Hiberneaza
        {
            get { return hiberneaza; }
            set { if (hiberneaza != value) hiberneaza = value; }
        }

        public Urs(bool h, int v, string n, float g) : base(v, n, g)
        {
            hiberneaza = h;
        }

        public override string ToString()
        {
            return base.ToString()+ " si hiberneaza: "+hiberneaza ;
        }

    }
}
