using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar2PAW
{
    class Urs:Animal
    {
        private bool hiberneaza;

        public bool Hiberneaza
        {
            get { return hiberneaza; }
            set { if (value != hiberneaza) hiberneaza = value; }

        }
        public Urs (bool h, int v, string n, float g):base(v,n,g)
        {
            hiberneaza = h;
        }
        public override string ToString()
        {
            return base.ToString() + " si hiberneaza " + hiberneaza;
        }
    }
}
