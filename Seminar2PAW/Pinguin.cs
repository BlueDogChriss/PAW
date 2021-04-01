using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar2PAW
{
    class Pinguin:Animal
    {
        private bool areIgloo;

        public bool AreIgloo
        {get {return areIgloo; }
            set { if (value != areIgloo) areIgloo = value; }
}

        public Pinguin (bool a, int v, string n, float g):base(v,n,g)
        {
            AreIgloo = a;
        }

        public override string ToString()
        {
            return base.ToString() + " si are Igloo " + areIgloo;
        }

    }
}
