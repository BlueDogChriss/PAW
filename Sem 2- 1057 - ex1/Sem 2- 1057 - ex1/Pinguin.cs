using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_2__1057___ex1
{
    class Pinguin : Animal
    {
        private bool areIgloo;

        public bool AreIgloo
        { get { return areIgloo; }
            set { if (areIgloo != value) areIgloo = value; }
        }

        public Pinguin(bool a, int v, string n, float g) : base(v, n, g)
        {
            areIgloo = a;
        }

        public override string ToString()
        {
            return base.ToString()+ " si are igloo:"+areIgloo;
        }

    }
}
