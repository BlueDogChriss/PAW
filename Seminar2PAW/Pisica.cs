using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar2PAW
{
    class Pisica:Animal
    {
        private bool lasaPar;

        public bool LasaPar { 
            get {return lasaPar; }
            set { if (value != lasaPar) lasaPar = value; }
        }
        public Pisica   (bool pa, int v, string n, float g) : base(v, n, g)
        {
            LasaPar = pa;
        }

        public override string ToString()
        {
            return base.ToString() + " si lasa par " + lasaPar;
        }
    }
}
